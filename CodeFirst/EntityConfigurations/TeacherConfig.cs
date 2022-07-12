using CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.EntityConfigurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
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

            builder.Property(t => t.Subject)
               .HasMaxLength(50)
               .IsRequired();

            var englishTeacherForGiorgi = new 
            {
                Id=1,
                FirstName = "nino",
                LastName = "ninodze",
                Gender = "qali",
                Subject = "English"
            };

            builder.HasData(englishTeacherForGiorgi);
        }
    }
}
