using Microsoft.EntityFrameworkCore;
using OZTF.EducationManageSys.Domain.Students;
using OZTF.EducationManageSys.Domain.Teachers;

namespace OZTF.EducationManageSys.Infrastructure.DataBase
{
    public class EducationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public EducationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(EducationContext).Assembly);
        }
    }
}
