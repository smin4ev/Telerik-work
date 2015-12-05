namespace StudentSystemHW.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentSystemHW.Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDBContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystemHW.Data.StudentSystemDBContext";
        }

        protected override void Seed(StudentSystemDBContext context)
        {
            context.Students.Add(new Student 
            {
                 FirstName = "Seed",
                 LastName = "Seeded",
                 Age=15
            
            });
        }
    }
}
