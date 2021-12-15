using System.Data.Entity;

namespace CodeFirstChallenge
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new StudentConfigurations());

        }

        public DbSet<Student> Students { get; set; }
       
    }
}