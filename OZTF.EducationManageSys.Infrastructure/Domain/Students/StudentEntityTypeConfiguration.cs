using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OZTF.EducationManageSys.Domain.Students;
using OZTF.EducationManageSys.Infrastructure.DataBase;

namespace OZTF.EducationManageSys.Infrastructure.Domain.Students
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("student", SchemaNames.Students);

            builder.HasKey(x => x.Id);

            builder.Property("_sNumber")
                .HasColumnName("SNumber")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property("_name")
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property("_birthday")
                .HasColumnName("Birthday")
                .HasColumnType("date")
                .IsRequired(true);

            builder.Property("_phone")
                .HasColumnName("Phone")
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired(true);

            builder.Property("_email")
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true);

            builder.Property("_admissionTime")
                .HasColumnName("AdmissionTime")
                .HasColumnType("date")
                .IsRequired(false);

            builder.Property("_dr")
                .HasColumnName("Dr")
                .HasColumnType("tinyint")
                .HasMaxLength(1)
                .IsRequired(true);

            builder.Property("_addTime")
                .HasColumnName("AddTime")
                .HasColumnType("date")
                .IsRequired(true);

            builder.Property("_updateTime")
                .HasColumnName("UpdateTime")
                .HasColumnType("date")
                .IsRequired(false);
        }
    }
}
