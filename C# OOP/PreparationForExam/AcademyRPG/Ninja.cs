using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja:Character,IFighter,IGatherer
    {
        private int attackPoint;
        

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            //this.attackPoint = 0;
            this.HitPoints = 1;
            
        }

        public int AttackPoints
        {
            get { return this.attackPoint; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {

            int indexOfTargetWithHigestHitpoint = -1;//няма значение на колко е равно, важно е да е отрицателно
            int highestHitPoint = int.MinValue;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0 && availableTargets[i].Owner != this.Owner)
                {
                    if (availableTargets[i].HitPoints > highestHitPoint)
                    {
                        highestHitPoint = availableTargets[i].HitPoints;
                        indexOfTargetWithHigestHitpoint = i;
                    }
                }
            }
            return indexOfTargetWithHigestHitpoint;


            //WorldObject target = availableTargets
            //    .OrderByDescending(t => t.HitPoints)
            //    .FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner);

            //return availableTargets.IndexOf(target);
            
           
        }
        
        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoint = this.attackPoint + resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.attackPoint = this.attackPoint + resource.Quantity * 2;
                return true;
            }
            return false;
            
        }
    }
}
