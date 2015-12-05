using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class Student : Person, ICommentable
    {
        private int classNumber;

        public Student(string name, int classNumber): base(name)
        {

            this.classNumber = classNumber;
        }
        public int ClassNumber
        {
            get { return this.classNumber; }
            set 
            {
                if (classNumber < 0)
                { 
                    throw new ArgumentOutOfRangeException("Not possible class number to be negativ number");
                }
            }
        }
        public void AddComment()
        {
            Console.WriteLine("I am a student!");
        }
        
    }
}
