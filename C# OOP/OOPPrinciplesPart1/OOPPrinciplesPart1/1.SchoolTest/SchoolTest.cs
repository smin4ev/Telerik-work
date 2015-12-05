using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    // С версия на VS2012 Express съм, тук няма опция за Class Diagram, затова не я прилагам!!!

    //We are given a school. In the school there are classes of students. 
    //Each class has a set of teachers. Each teacher teaches a set of disciplines. 
    //Students have name and unique class number. Classes have unique text identifier. 
    //Teachers have name. Disciplines have name, number of lectures and number 
    //of exercises. Both teachers and students are people. Students, classes, teachers and 
    //disciplines could have optional comments (free text block).
    //Your task is to identify the classes (in terms of  OOP) and their attributes and operations, 
    //encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

    class SchoolTest
    {
        static void Main(string[] args)
        {
            Student Ivan = new Student("Ivan", 18);
            Student Georgi = new Student("Georgi", 17);
            Student Misho = new Student("Misho", 16);

            Disciplines Mathematic = new Disciplines("Mathematic", 10, 1000);
            Disciplines Geographi = new Disciplines("Geographi", 15, 15);

            Teacher Aleksandrov = new Teacher("Aleksandrov"); //new List<Disciplines> {new Disciplines("Mathematic",10,10), new Disciplines("Geographi", 15,20)}
            Aleksandrov.SetOfDisciplines.Add(Mathematic);
            Aleksandrov.SetOfDisciplines.Add(Geographi);

            Class MyClass = new Class("Class 12B");

            MyClass.SetOfTeashers.Add(Aleksandrov);
            MyClass.SetOfStudents.Add(Ivan);
            MyClass.SetOfStudents.Add(Georgi);
            MyClass.SetOfStudents.Add(Misho);
            Console.WriteLine("My class is {0}, we are {1} friands, our master - teacher is {2} and he teaching {3}! ", MyClass.TextIdentifair,
                MyClass.SetOfStudents.Count, Aleksandrov.Name, Mathematic.Name);

            
            
          
               
        }
    }
}
