using ExceptionsHomework.Contracts;
using ExceptionsHomework.Enums;
using ExceptionsHomework.Utils;

namespace ExceptionsHomework.Models
{
    public class SimpleMathExam : IExam
    {
        private const int ProblemsSolvedForPass = 3;
        private const int ProblemsSolvedForAverageGrade = 5;
        private const int ProblemsSolvedForVeryGoodGrade = 7;
        private const int ProblemsSolvedForExcellentGrade = 9;

        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }
            private set
            {
                Validator.ValidateIfNumberInRange(
                    value,
                    MinProblemsSolved,
                    MaxProblemsSolved,
                    "Problems solved");

                this.problemsSolved = value;
            }
        }

        public ExamResult Check()
        {
            if (this.ProblemsSolved >= ProblemsSolvedForExcellentGrade)
            {
                return new ExamResult(
                    (int)GradeValues.Max,
                    (int)GradeValues.Min,
                    (int)GradeValues.Max,
                    "Excelent result: everything done!");
            }

            if (this.ProblemsSolved >= ProblemsSolvedForVeryGoodGrade)
            {
                return new ExamResult(
                    (int)GradeValues.VeryGood,
                    (int)GradeValues.Min,
                    (int)GradeValues.Max,
                    "Very good results: almost everything done!");
            }

            if (this.ProblemsSolved >= ProblemsSolvedForAverageGrade)
            {
                return new ExamResult(
                   (int)GradeValues.Average,
                   (int)GradeValues.Min,
                   (int)GradeValues.Max,
                    "Average results: about a half problems are done!");
            }

            if (this.ProblemsSolved >= ProblemsSolvedForPass)
            {
                return new ExamResult(
                    (int)GradeValues.Pass,
                    (int)GradeValues.Min,
                    (int)GradeValues.Max,
                    "Poor results: almost nothing is done!");
            }

            return new ExamResult(
                (int)GradeValues.Min,
                (int)GradeValues.Min,
                (int)GradeValues.Max,
                "Bad results: nothing done!");
        }
    }
}