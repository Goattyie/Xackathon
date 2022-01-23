using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xackathon.Bll;
using Xackathon.Bll.Service;
using Xackathon.Dal.Models;
using Xackathon.Sql;
using Xackathon.Sql.Repository;

namespace Xackathon.DI
{
    public class IoC
    {
        public static void Register(IServiceCollection services, string dbConnection)
        {
            services.AddDbContext<SqlContext>(options => options.UseNpgsql(dbConnection));

            services.AddScoped<IRepository<Role>, RoleRepository>();
            services.AddScoped<IRepository<Region>, RegionRepository>();
            services.AddScoped<IProblemCategoryRepository, ProblemCategoryRepository>();
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IRepository<Story>, StoryRepository>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IProblemCategoryService, ProblemCategoryService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IStoryService, StoryService>();
            services.AddScoped<Services>();
        }
    }
}
