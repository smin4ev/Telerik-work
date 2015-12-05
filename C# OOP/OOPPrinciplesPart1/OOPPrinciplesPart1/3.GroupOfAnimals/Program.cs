using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GroupOfAnimals
{
    //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors 
    //and methods. Dogs, frogs and cats are Animals. All animals can produce sound 
    //(specified by the ISound interface). Kittens and tomcats are cats. All animals are 
    //described by age, name and sex. Kittens can be only female and tomcats can be only male. 
    //Each animal produces a specific sound. Create arrays of different kinds of animals 
    //and calculate the average age of each kind of animal using a static method (you may use LINQ).



    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[]
            {
                new Cat("Maca",12,"fimale"),
                new Kitten("Iva",1),
                new Tomcat("Vasil",5),
                new Cat("Minka",8,"")
                
            };
            Frog[] frogs = new Frog[]
            {
                new Frog("Ivan", 4, "male"),
                new Frog("Spas", 9, "male"),
                new Frog("Misho", 12, "??"),
                new Frog("Ema", 2, "female")
            };
            Dog[] dogs = new Dog[]
            {
                new Dog("Balkan",10,"male"),
                new Dog("Sharo",3, "male"),
                new Dog("Ulichen",2,""),
                new Dog("Rex",9,"male")
            };
            Console.WriteLine("Avarage age of cats is " + Animal.AvarageAge(cats));
            Console.WriteLine("Avarage age of frogs is " + Animal.AvarageAge(frogs));
            Console.WriteLine("Avarage age of dogs is " + Animal.AvarageAge(dogs));

            dogs[2].ProduceSound();
            frogs[1].ProduceSound();
            cats[0].ProduceSound();
            
        }
    }
}
