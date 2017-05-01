using System;

namespace Exceptions
{
    public class CSharpExam : IExam
    {
        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score cannot be negative!");
            }

            if (100 < score)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score cannot be greater than 100!");
            }

            this.Score = score;
        }

        public int Score { get; }

        public ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
