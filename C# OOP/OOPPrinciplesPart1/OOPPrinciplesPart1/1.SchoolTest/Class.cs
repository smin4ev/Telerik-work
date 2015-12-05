using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class Class : ICommentable
    {
        private List<Teacher> setOfTeashers = new List<Teacher>();
        private List<Student> setOfStudents = new List<Student>();
        private string textIdentifier;

        public Class(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
        }

        public string TextIdentifair
        {
            get { return this.textIdentifier; }
            set { this.textIdentifier = value; }
        }
        public List<Teacher> SetOfTeashers
        {
            get { return this.setOfTeashers; }
            set { this.setOfTeashers = value; }
        }
        public List<Student> SetOfStudents
        {
            get { return this.setOfStudents; }
            set { this.setOfStudents = value; }
        }

        public void AddComment()
        {
            Console.WriteLine("This is a class!");
        }
       
    }
}
