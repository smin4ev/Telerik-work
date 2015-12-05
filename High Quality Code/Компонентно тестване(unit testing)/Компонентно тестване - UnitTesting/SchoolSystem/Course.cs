
namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course : IEquatable<Course>
    {
        
        private string name;
     
        private IList<Student> attendingStudents;

        private int capacity;

        public Course(string name, int courseCapacity)
        {
            this.Name = name;
            this.Capacity = courseCapacity;
            this.attendingStudents = new List<Student>(courseCapacity);
        }

        public string Name
        {
            get
            {
                return this.name.ToLower();
            }

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The value for 'Name' can not contain null, empty string or only white spaces.");
                }

                this.name = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value for 'Capacity' can not be a negative number");
                }

                this.capacity = value;
            }
        }

        public bool IsAttendingTheCourse(Student student) 
        {
            if (student == null)
            {
                throw new ArgumentException("The value for 'student' can not be 'null'.");
            }

            if (this.attendingStudents.Contains(student))
            {
                return true;
            }

            return false;
        }

      
        public void AddNewStudent(Student newStudent) 
        {
            if (newStudent == null)
            {
                throw new ArgumentException("The value for 'student' can not be 'null'.");
            }

            if (this.IsAttendingTheCourse(newStudent))
            {
                throw new InvalidOperationException("The operation can not be performed. Student with the same ID attending.");
            }

            if (this.attendingStudents.Count >= this.capacity)
            {
                throw new InvalidOperationException("The student can no be sign because the capacity of the course is reached.");
            }

            this.attendingStudents.Add(newStudent);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentException("The value for 'student' can not be 'null'.");
            }

            if (!this.IsAttendingTheCourse(student))
            {
                throw new InvalidOperationException("The operation can not be performed. Student with the same ID it is not attending the course");
            }

            this.attendingStudents.Remove(student);
        }

       
        public bool Equals(Course other)
        {
            if (this.Name == other.Name)
            {
                return true;
            }

            return false;
        }
    }
}
