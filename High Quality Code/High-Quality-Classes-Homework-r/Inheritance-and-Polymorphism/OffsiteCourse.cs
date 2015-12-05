using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse:Course
    {
        private string town;

        public OffsiteCourse(string nameOfTheCourse, string teacherName, List<string> students, string town)
            : base(nameOfTheCourse, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get 
            {
                return this.town;
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Town cann't be null or empty");
                }
                else
                {
                    this.town = value;
                }
            }
        }

        public override string ToString()
        {
            string result = base.ToString() + string.Format("; Town = {0}", this.town);
            return result;
        }
    }
}
