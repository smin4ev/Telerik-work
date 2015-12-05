namespace StudentSystemHW.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {

        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;
        private ICollection<Exam> exams;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
            this.exams = new HashSet<Exam>();
        }

        
        public int StudentId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]

        public string LastName { get; set; }

        public int Number { get; set; }

        public int Age { get; set; }

        public StudentStatus StudentStatus { get; set; }

        public virtual ICollection<Course> Courses 
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
        public virtual ICollection<Exam> Exams
        {
            get
            {
                return this.exams;
            }
            set
            {
                this.exams = value;
            }

        }
    }
}
