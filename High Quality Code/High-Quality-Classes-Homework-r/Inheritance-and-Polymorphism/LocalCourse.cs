using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse:Course
    {
        private string lab;

        public LocalCourse(string nameOfTheCourse, string teacherName, List<string> students, string lab)
            : base(nameOfTheCourse, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get { return this.lab; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Laboratory cann't be null or empty!");
                }
                else
                {
                    this.lab = value;
                }
            }
        }

        public override string ToString()
        {
            string result = base.ToString() + string.Format("; Lab = {0}", this.lab);
            return result;
        }
    }
}
