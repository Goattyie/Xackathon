using Microsoft.EntityFrameworkCore;
using Xackathon.Dal.Models;

namespace Xackathon.Sql
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<RegionContractors> RegionContractors { get; set; }
        public DbSet<MailingQuery> MailingQueries { get; set; }
        public DbSet<ProblemCategory> ProblemCategories  { get; set; }
        public DbSet<StoredProblemCategory> StoredProblemCategories { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ContractorRequest> ContractorRequests { get; set; }
        public DbSet<ProblemCategoryRequest> ProblemCategoryRequests { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<StoredRequest> StoredRequests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<StoppingPoint> StoppingPoints { get; set; }
        public DbSet<StoppingRoutePoint> StoppingRoutePoints { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<TransportDriver> TransportDrivers { get; set; }
        public DbSet<TransportRoutes> TransportRoutes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
