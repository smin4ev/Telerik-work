using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonTest
{
    public class Person
    {
        private string name;
        private int? age;


        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return string.Format("Person name is {0}, age {1}", this.Name, this.Age !=null ? this.Age.ToString(): "Undefined");
            //this.Age !=null ? this.Age.ToString():"Undefined" - Тернарен оператор, казва "Ако this.Age  е различно от null, напиши колко е, ако е null, напиши Undefined"
        }
    }
}
