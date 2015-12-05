using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;

    private int score;
    public int Score 
    {
        get { return this.score; }
        set 
        {
            if (this.Score < MinGrade || this.Score > MaxGrade)
            {
                throw new ArgumentOutOfRangeException("Score must be between 0 and 100");
            }
            else 
            {
                this.score = value;
            }
        }
    }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new NullReferenceException();
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {    
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
