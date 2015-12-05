using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystemHW.Model;

namespace StudentSystemHW.Data
{
    public class StudentSystemDBContext:DbContext
    {
        public StudentSystemDBContext()
            : base("StudentSystemHW")
        { 
        
        }


        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Exam> Exams { get; set; }
    }
}
