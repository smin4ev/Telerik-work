using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    //Define abstract class Human with first name and last name. 
    //Define new class Student which is derived from Human and has 
    //new field – grade. Define class Worker derived from Human with 
    //new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
    //that returns money earned by hour by the worker. Define the proper 
    //constructors and properties for this hierarchy. Initialize a list 
    //of 10 students and sort them by grade in ascending order 
    //(use LINQ or OrderBy() extension method). Initialize a list of 10 workers 
    //and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.

    class TestProgram
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
           {
                new Student("Zdravko", "Petrov", 8),
                new Student("Ivo", "Vasilev", 2),
                new Student("Zdravko", "Petrov", 3), 
                new Student("Zahari", "Vasilev", 4), 
                new Student("Ivo", "Marinov", 6), 
                new Student("Apsaruh", "Ivanov", 12),
                new Student("Zdravko", "Zdravkov", 10),
                new Student("Marin", "Marinov", 10),
                new Student("Zahari","Ivanov",11),
                new Student("Sasho", "Tomov",1)
           };

            //With  LINQ
            var gradeInAscendingOrder =
                from student in students
                orderby student.Grade 
                select student;
            foreach (var person in gradeInAscendingOrder)
            {
                Console.WriteLine("{0} {1} - {2} grade", person.FirstName,person.LastName, person.Grade);//Защо като махна placeholders не 
            }
            Console.WriteLine();

            ////With Lambda
            //var gradeInAscendingOrderLambda = students.OrderBy(x => x.Grade);
            //foreach (var person in gradeInAscendingOrderLambda)
            //{
            //    Console.WriteLine("{0} {1} - {2} grade",person.FirstName,person.LastName, person.Grade);
            //}

            Console.WriteLine();
            List<Worker> workers = new List<Worker>
            {
                new Worker("Spas","Sirakov", 800, 8),
                new Worker("Vasil", "Bashov", 1000,6),
                new Worker("Penka", "Petrova", 900, 7),
                new Worker("Mitko", "Petrov", 1200,10),
                new Worker("Sasho", "Sashov", 1232, 5),
                new Worker("Mitko", "Subev", 2000, 12),
                new Worker("Ivan", "Ivanov", 900, 4),
                new Worker("Martin", "Petrov", 1000,7),
                new Worker("Vasil", "Kostov", 600,2),
                new Worker("Miro", "Canev", 800,4)
            };
          
            var workersMoneyPerHourDescending =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;
            foreach (var worker in workersMoneyPerHourDescending)
            {
                Console.WriteLine("{0} {1} - money per hour {2} - week selary {3} - work hour per day {4}",worker.FirstName,worker.LastName, worker.MoneyPerHour(), worker.WeekSelary, worker.WorkHoursPerDay);
            }

            Console.WriteLine();
            //Marge of 2 list
            var groupOfWorkersAndStudents = students.Concat<Human>(workers).ToList();
            //With LINQ
             var wholeGroup =
                from person in groupOfWorkersAndStudents
                orderby person.FirstName, person.LastName
                select person;
             foreach (var person in wholeGroup)
             {
                 Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
             }

            ////With lambda
            // Console.WriteLine();
            // groupOfWorkersAndStudents = groupOfWorkersAndStudents.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            // foreach (var person in groupOfWorkersAndStudents)
            // {
            //     Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            // }

                
        }
    }
}
