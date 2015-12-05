using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentDataTest
{
    //1.Define a class Student, which contains data about a student – first, middle and last name, 
    //SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
    //Use an enumeration for the specialties, universities and faculties. Override the standard 
    //methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

    //2.Add implementations of the ICloneable interface. The Clone() method should deeply copy 
    //all object's fields into a new object of type Student.

    //Implement the  IComparable<Student> interface to compare students by 
    //names (as first criteria, in lexicographic order) and by social security 
    //number (as second criteria, in increasing order).



    public class StudentDataTest
    {
        
        static void Main(string[] args)
        {
            Student georgi = new Student ( "Georgi", "Georgiev", "Petrov", "111222", "Sofia", "0888123456",
                "georgi@abv.bg",4,University.BiologyUnicersity,Facultity.EcologyFaculty, Speciality.Ecology);
            Student petar = new Student("Petar", "Petrov", "Petrov", "123321", "Plovdiv", "0898654321", 
                "petar@abv.bg",3, University.TechnicalUniversity, Facultity.ComputerSciense, Speciality.Mathematic);
            Student petar1 = new Student("Petar", "Davidov", "Petrov", "9876543", "Pleven", "0898445566",
                "ivan1@abv.bg",1, University.EconomyUniversity, Facultity.Financial, Speciality.Mathematic);
            Console.WriteLine(georgi);
            Console.WriteLine();
            Console.WriteLine(petar == petar1);
            Console.WriteLine();

            Student cloneOfGeorgi = georgi.Clone();
            Console.WriteLine(cloneOfGeorgi);

            Console.WriteLine();
            Console.WriteLine(petar1.CompareTo(petar));
            Console.WriteLine(cloneOfGeorgi.CompareTo(georgi));
        }
    }
}
