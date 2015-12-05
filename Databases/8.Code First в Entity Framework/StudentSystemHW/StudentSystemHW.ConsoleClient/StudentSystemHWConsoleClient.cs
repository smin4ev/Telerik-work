using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystemHW.Data;
using StudentSystemHW.Data.Migrations;
using StudentSystemHW.Model;

namespace StudentSystemHW.ConsoleClient
{
    public class StudentSystemHWConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDBContext, Configuration>());

            var db = new StudentSystemDBContext();

            var student = new Student
            {
                Age = 18,
                FirstName = "Aleksandar",
                LastName = "Minchev",
                StudentStatus = StudentStatus.Onsite
            };

            student.Courses.Add(new Course 
            {
                Name = "Entity Framework"
            });

            db.Students.Add(student);
            db.SaveChanges();

            var savedStudent = db.Students.First();
            Console.WriteLine(savedStudent.StudentId + ":" + savedStudent.FirstName + " " + savedStudent.LastName );
        }
    }
}
