using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Boar:Animal,ICarnivore,IHerbivore
    {
        private int BiteSize;

        public Boar(string name, Point position)
            : base(name, position, 4)
        {
            this.BiteSize = 2;  
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if(plant!=null )
            {
                this.Size++; 
               return plant.GetEatenQuantity(this.BiteSize);
               
            }
                return 0;
        }

    }
}
