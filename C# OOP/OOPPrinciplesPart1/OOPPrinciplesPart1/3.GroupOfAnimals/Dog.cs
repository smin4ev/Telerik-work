using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GroupOfAnimals
{
    public class Dog:Animal, ISound
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        { 
        }
        public void ProduceSound()
        {
            Console.WriteLine("I am a dog, bau-bau!");
        }
    }
}
