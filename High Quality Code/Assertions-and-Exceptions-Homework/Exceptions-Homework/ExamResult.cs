using System;

public class ExamResult
{
    private int grade = 0;
    private int minGrade = 0;
    private int maxGrade = 100;
    private string comments = null;

    public int Grade 
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (this.Grade < 0 || this.Grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade can not be < 0 or > 100");
            }

            this.grade = value;
        }
    }

    public int MinGrade 
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0 )
            {
                throw new ArgumentOutOfRangeException("Minimal grade cant be < 0");
            }

            this.minGrade = value;
        }
    }
  
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("Maximal cant be <= Minimal");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Comment can not be empty or null");
            }

            this.comments = value;
        }
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
