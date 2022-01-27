using Telegram.Bot;
using Xackathon.TelegramBot;
using Xackathon.TelegramBot.Commands;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddNewtonsoftJson();

var token = builder.Configuration.GetValue<string>("BotToken");
var url = builder.Configuration.GetValue<string>("MainUrl");
var telegram = new TelegramBotClient(token);
await telegram.SetWebhookAsync($"{url}/api/command");

builder.Services.AddSingleton<ITelegramBotClient>(telegram);
builder.Services.AddScoped<CommandHandler>();
builder.Services.AddTransient<ICommand, CreateRequestCommand>();
builder.Services.AddTransient<ICommand, StartCommand>();

var app = builder.Build();

app.MapControllers();

app.Run();
