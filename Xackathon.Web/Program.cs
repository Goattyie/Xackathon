using Microsoft.AspNetCore.Diagnostics;
using Microsoft.OpenApi.Models;
using Xackathon.Bll;
using Xackathon.DI;
using Xackathon.Sql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Xackathon API", Version = "v1" });
    var filePath = Path.Combine(System.AppContext.BaseDirectory, "documentation.xml");
    c.IncludeXmlComments(filePath);
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod();
    });
});

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
IoC.Register(builder.Services, connection);

var app = builder.Build();
app.UseSwagger();
app.UseCors();
app.UseExceptionHandler("/error");
app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "Xackathon API"));

if (app.Environment.IsProduction())
{
    app.UseExceptionHandler(c => c.Run(async context =>
    {
        var exception = context.Features
            .Get<IExceptionHandlerPathFeature>()
            .Error;
        var response = new { error = exception.Message };
        await context.Response.WriteAsJsonAsync(response);
    }));
}

app.MapControllers();

app.Run();
