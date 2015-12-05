using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    class CoursesExamples
    {
        static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases", "Niki Kostov", new List<string>() { "Peter", "Maria" }, "Enterprice");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse("CSS & HTML", "Niki Kostov", new List<string>() { "Peter", "Maria" }, "Plovdiv");
            Console.WriteLine(offsiteCourse);

            //localCourse.Lab = "Enterprise";
            //Console.WriteLine(localCourse);

            //localCourse.Students = new List<string>() { "Peter", "Maria" };
            //Console.WriteLine(localCourse);

            //localCourse.TeacherName = "Svetlin Nakov";
            //localCourse.Students.Add("Milena");
            //localCourse.Students.Add("Todor");
            //Console.WriteLine(localCourse);

            //OffsiteCourse offsiteCourse = new OffsiteCourse(
            //    "PHP and WordPress Development", "Mario Peshev", 
            //    new List<string>() { "Peter", "Maria" });
            //Console.WriteLine(offsiteCourse);
        }
    }
}
