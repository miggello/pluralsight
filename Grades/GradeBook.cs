using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        protected List<float> grades;

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator(); 
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {

                destination.WriteLine(grades[i]);
            }
        }

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = CreateGradeBook();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        private static GradeStatistics CreateGradeBook()
        {
            return new GradeStatistics();
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        
    }
}
