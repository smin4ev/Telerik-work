using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GroupOfAnimals
{
    public class Animal
    {
        public string Name { get;  set; }
        public int Age { get;  set; }
        public string Sex { get;  set; }

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public void ProduceSound()
        {
            Console.WriteLine("I am an animal!");
        }

        public static double AvarageAge(Animal[] animals)
        {
            double sum = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                sum = sum + animals[i].Age;
            }
            return sum / animals.Length;
        }
    }
}
