using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirstNameBeforeLastNameAlfabet
{
    //3.Write a method that from a given array of students finds all students 
    //whose first name is before its last name alphabetically. Use LINQ query operators.

    //4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    //5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort 
    //the students by first name and last name in descending order. Rewrite the same with LINQ.




    class FirstNameBeforeLastNameAlfabet
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Zdravko", "Petrov", 19), 
                new Student("Zahari", "Vasilev", 17), 
                new Student("Ivo", "Marinov", 21), 
                new Student("Apsaruh", "Ivanov", 23),
                new Student("Zdravko", "Zdravkov", 27),
            };
            //3 Task
            Console.WriteLine("Task 3:");
            var firstNameBeforeSecond =
                from student in students
                where (student.FirstName).CompareTo(student.SecondName) == -1
                select student;

            foreach (var person in firstNameBeforeSecond)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.SecondName);
            }
            //End 3 task
            Console.WriteLine();
            //4 Task
            Console.WriteLine("Task 4:");
            var ageBetween18And24 =
                from student in students
                where (student.Age > 18 && student.Age < 24)
                select student;
            foreach (var person in ageBetween18And24)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.SecondName);
            }
            //End 4 task
            Console.WriteLine();

            //5 task
            
            Console.WriteLine("Task 5:");
            //-lambda expresion
            Console.WriteLine("With lambda expression:");
            var sortedStudentWithLabmda = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.SecondName);
            foreach (var person in sortedStudentWithLabmda)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.SecondName);
            }
            Console.WriteLine();
            //-LINQ 
            Console.WriteLine("With LINQ:");
            var sortedStudentWithLINQ =
                from student in students
                orderby student.FirstName descending, student.SecondName descending
                select student;
            foreach(var person in sortedStudentWithLINQ)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.SecondName);
            }
            //End task 5 
                 
        }
    }
}
