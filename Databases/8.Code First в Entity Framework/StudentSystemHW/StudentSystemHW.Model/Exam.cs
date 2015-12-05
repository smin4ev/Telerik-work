using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemHW.Model
{
    public class Exam
    {
        private ICollection<Student> students;

        public Exam()
        {
            this.ExamID = Guid.NewGuid();
            this.students = new HashSet<Student>();
        }
        
        [ForeignKey("Course")]
        public Guid ExamID { get; set; }

        public string Name { get; set; }

        public DateTime Start{get;set;}

        public DateTime End { get; set; }


        //[ForeignKey("Course")]
        //public Guid CourseID { get; set; }

        public virtual Course Course { get; set; }

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

    }
}
