using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class Disciplines:ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines(string name, int numberOfLectures, int NumberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }
        public int NumberOfExercise
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value;}
        }

        public void AddComment()
        {
            Console.WriteLine("This is some discipline!");
        }


    }
}
