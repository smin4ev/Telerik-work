using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class Teacher:Person, ICommentable
    {
        private List<Disciplines> setOfDisciplines = new List<Disciplines>();

        public Teacher(string name): base(name)
        {

        }

        public List<Disciplines> SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
            set { this.setOfDisciplines = value; }
        }

        public void AddComment()
        {
            Console.WriteLine("I am a teacher!");
        }

    }
}
