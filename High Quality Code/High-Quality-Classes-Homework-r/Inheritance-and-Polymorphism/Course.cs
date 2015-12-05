namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        private string nameOfTheCourse;
        private string teacherName;
        private List<string> students;

        public Course(string nameOfTheCourse, string teacherName, List<string> students)
        {
            this.nameOfTheCourse = nameOfTheCourse;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string NameOfTheCourse
        {
            get
            {
                return this.nameOfTheCourse;
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name of course cann't be null or empty");
                }
                else 
                {
                    this.nameOfTheCourse = value;
                }
            }
        }

        public string TeacherName
        {
            get 
            {
                return this.teacherName;
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name of teacher cann't be null or empty");
                }
                else 
                {
                    this.teacherName = value;
                }
            }
        }

        public List<string> Students
        {
            get 
            {
                return this.students;
            }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                else 
                {
                    this.students = value;
                }
            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Course name = {0}", this.NameOfTheCourse);
            if (this.TeacherName != null)
            {
                result.AppendFormat("; Teacher name = {0}", this.TeacherName);
            }
            result.AppendFormat("; Student = {0}", this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
