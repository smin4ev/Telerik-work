
namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    
    public class School
    {
        
        private static int courseCapacity = 30;

        
        private static uint maxID = 99999;

        
        private static uint minID = 10000;

        
        private IList<Course> courses;

        
        private IList<Student> students;

        private uint studentIDGenerator;

        public School()
        {
            this.Courses = new List<Course>();
            this.Students = new List<Student>();
            this.studentIDGenerator = minID;
        }

        protected IList<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                this.courses = value;
            }
        }

        protected IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public Student AddNewStudent(string newStudentName)
        {
            if (this.studentIDGenerator == maxID + 1)
            {
                throw new InvalidOperationException("The student can no be sign because the capacity of the school is reached.");
            }

            Student newStudent = new Student(this.studentIDGenerator, newStudentName);
            this.Students.Add(newStudent);
            this.studentIDGenerator++;

            return newStudent;
        }

        public Course AddNewCourse(string newCourseName)
        {
            if (IndexOfCourse(newCourseName, this.courses) >= 0)
            {
                throw new InvalidOperationException("The operation can not be performed. Course with the same Name has already signed in the school.");
            }

            Course newCourse = new Course(newCourseName, courseCapacity);
            this.Courses.Add(newCourse);
            return newCourse;
        }

        public void SignUpStudentForCourse(uint id, string courseName)
        {
            int indexStudent = IndexOfStudent(id, this.students);
            if (indexStudent < 0)
            {
                throw new InvalidOperationException(string.Format("The operation can not be performed. Student with ID '{0}' does not attending the school.", id));
            }

            int indexCourse = IndexOfCourse(courseName, this.courses);
            if (indexCourse < 0)
            {
                throw new InvalidOperationException(string.Format("The operation can not be performed. Course with name '{0}' does not exist in the school.", courseName));
            }

            this.courses[indexCourse].AddNewStudent(this.students[indexStudent]);
        }

        public void SignOutStudentOfCourse(uint id, string courseName)
        {
            int indexStudent = IndexOfStudent(id, this.students);
            if (indexStudent < 0)
            {
                throw new InvalidOperationException(string.Format("The operation can not be performed. Student with ID '{0}' does not attending the school.", id));
            }

            int indexCourse = IndexOfCourse(courseName, this.courses);
            if (indexCourse < 0)
            {
                throw new InvalidOperationException(string.Format("The operation can not be performed. Course with name '{0}' does not exist in the school.", courseName));
            }

            this.courses[indexCourse].RemoveStudent(this.students[indexStudent]);
        }

        private static int IndexOfStudent(uint id, IList<Student> setOfStudents)
        {
            for (int i = 0; i < setOfStudents.Count; i++)
            {
                if (setOfStudents[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }

        private static int IndexOfCourse(string name, IList<Course> setOfCourses)
        {
            for (int i = 0; i < setOfCourses.Count; i++)
            {
                if (setOfCourses[i].Name == name.ToLower())
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
