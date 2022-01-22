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

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<Services>();
        }
    }
}
