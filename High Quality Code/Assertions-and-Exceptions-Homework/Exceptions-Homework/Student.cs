using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exam;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name of student can not be null or emprty");
            }
            else
            {
                this.firstName = value;
            }
        }
    }
    public string LastName 
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Last name of student can not be null or empty");
            }
            else 
            {
                this.lastName = value;
            }
        }
    }
    public IList<Exam> Exams 
    {
        get
        {
            return this.exam;
        }
        set 
        {
            if (value == null)
            {
                throw new ArgumentException();
            }
            else
            {
                this.exam = value;
            }
        }
    }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null)
        {
            Console.WriteLine("Invalid first name!");
            Environment.Exit(0);
        }

        if (lastName == null)
        {
            Console.WriteLine("Invalid first name!");
            Environment.Exit(0);
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new Exception("Wow! Error happened!!!");
        }

        if (this.Exams.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
            return null;
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            // Cannot calculate average on missing exams
            throw new Exception();
        }

        if (this.Exams.Count == 0)
        {
            // No exams --> return -1;
            return -1;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
