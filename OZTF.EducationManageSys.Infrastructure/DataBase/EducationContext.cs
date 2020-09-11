using Microsoft.EntityFrameworkCore;
using OZTF.EducationManageSys.Domain.Students;

namespace OZTF.EducationManageSys.Infrastructure.DataBase
{
    public class EducationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public EducationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(EducationContext).Assembly);
        }
    }
}
