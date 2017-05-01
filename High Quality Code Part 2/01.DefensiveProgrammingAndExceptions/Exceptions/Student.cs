using System;
using System.Collections.Generic;
using System.Linq;

namespace Exceptions
{
    public class Student
    {
        public Student(string firstName, string lastName, IList<IExam> exams = null)
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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<IExam> Exams { get; set; }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new Exception("Wow! Error happened!!!");
            }

            if (this.Exams.Count != 0)
            {
                return this.Exams.Select(t => t.Check()).ToList();
            }

            Console.WriteLine("The student has no exams!");

            return null;
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

            var examScore = new double[this.Exams.Count];
            var examResults = this.CheckExams();
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
