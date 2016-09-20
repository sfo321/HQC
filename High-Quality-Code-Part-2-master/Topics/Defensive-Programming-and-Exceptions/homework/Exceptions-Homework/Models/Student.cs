using System;
using System.Linq;
using System.Collections.Generic;
using ExceptionsHomework.Utils;
using ExceptionsHomework.Contracts;

namespace ExceptionsHomework.Models
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<IExam> exams;

        public Student(string firstName, string lastName, IList<IExam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Validator.ValidateString(value, "FirstName");
                Validator.ValidateName(value, "FirstName");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.ValidateString(value, "LastName");
                Validator.ValidateName(value, "LastName");

                this.lastName = value;
            }
        }

        public IList<IExam> Exams
        {
            get
            {
                return new List<IExam>(this.exams);
            }
            set
            {
                if (value != null)
                {
                    this.exams = value;
                }
                else
                {
                    this.exams = new List<IExam>();
                }
            }
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("There are no exams to check!");
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
            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("There are no exams to calculate!");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
