using CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.EntityConfigurations
{
    public class PupilConfig : IEntityTypeConfiguration<Pupil>
    {
        public void Configure(EntityTypeBuilder<Pupil> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.LastName)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(t => t.Gender)
               .HasMaxLength(20)
               .IsRequired();

            builder.Property(t => t.Class)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .HasMany(p => p.Teachers)
               .WithMany(t => t.Pupils)
               .UsingEntity<Dictionary<string, object>>(
                   "PupilTeacher",
                   r => r.HasOne<Teacher>().WithMany().HasForeignKey("TeachersId"),
                   l => l.HasOne<Pupil>().WithMany().HasForeignKey("PupilsId"),
                   je =>
                   {
                       je.HasKey("TeachersId", "PupilsId");
                       je.HasData(
                           new { TeachersId = 1, PupilsId = 1 }
                           );
                   });

            var giorgi = new 
            {
                Id=1,
                FirstName = "giorgi",
                LastName = "giorgadze",
                Gender = "kaci",
                Class = "mexute klasi"
            };

            builder.HasData(giorgi);
        }
    }
}
