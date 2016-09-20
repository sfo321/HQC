using ExceptionsHomework.Contracts;
using ExceptionsHomework.Utils;

namespace ExceptionsHomework.Models
{
    public class CSharpExam : IExam
    {
        private const int scoreMin = 0;
        private const int scoreMax = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            private set
            {
                Validator.ValidateIfNumberInRange(value, scoreMin, scoreMax, "Score");
            }
        }
        public ExamResult Check()
        {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
