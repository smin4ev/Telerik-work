using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Cooking
{
   public class Bowl
    {
        private List<Vegetable> bowlList = new List<Vegetable>();


        public List<Vegetable> BowlList
        {
            get
            {
                return this.bowlList;
            }


            set
            {
                value = this.bowlList;
            }
        }

    }
}
