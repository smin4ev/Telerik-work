namespace StudentSystemHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.CourseID = Guid.NewGuid();
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
        }

        public Guid CourseID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }

        //[ForeignKey("Exam")]
        //public int ExamID { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual ICollection<Student> Students
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

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }

        }
    }
}
