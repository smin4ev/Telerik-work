using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirstNameBeforeLastNameAlfabet
{
    public  class Student
    {
        //fields
        private string firstName;
        private string secondName;
        private int age;

        //constructors
        public Student(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }
        public Student(string firstName, string secondName, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
            
        }

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string SecondName
        {
            get { return this.secondName; }
        }
        public int Age
        {
            get { return this.age; }
        }
    }
    

}
