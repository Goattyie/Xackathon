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
        public DbSet<ProblemCategory> ProblemCategories { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
