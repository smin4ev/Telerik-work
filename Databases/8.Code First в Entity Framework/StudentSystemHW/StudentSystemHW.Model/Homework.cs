using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemHW.Model
{
     public class Homework
    {
     
        public int HomeworkID { get; set; }

        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public Guid CourseID { get; set; }

        public virtual Course Course {get; set;}

         [ForeignKey("Student")]
        public int StudentIdentification { get; set; }

        public virtual Student Student { get; set; }

    }
}
