using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OZTF.EducationManageSys.Domain.Teachers;
using OZTF.EducationManageSys.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Infrastructure.Domain.Teachers
{
    public class TeacherEntityTypeConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher", SchemaNames.Teachers);

            builder.HasKey(x => x.Id);

            builder.Property("_name")
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property("_tNumber")
                .HasColumnName("TNumber")
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

            builder.Property("_entryTime")
                .HasColumnName("EntryTime")
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
