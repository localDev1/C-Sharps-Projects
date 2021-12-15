using System.Data.Entity.ModelConfiguration;

namespace CodeFirstChallenge
{
    public class StudentConfigurations : EntityTypeConfiguration<Student>
    {
        public StudentConfigurations()
        {
            this.Property(s => s.FName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.LName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.FName)
                .IsConcurrencyToken();

            this.Property(s => s.LName)
               .IsConcurrencyToken();

            // Configure a one-to-one relationship between Student & StudentAddress
            this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
                .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
        }
    }
}