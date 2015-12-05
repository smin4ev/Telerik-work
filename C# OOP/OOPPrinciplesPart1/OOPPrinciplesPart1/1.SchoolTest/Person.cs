using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public abstract class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (name == null  || name == "")
                {
                    throw new ArgumentNullException("Name can not be null ot  empty");
                }
                this.name = value;
            }
            
        }

    }
}
