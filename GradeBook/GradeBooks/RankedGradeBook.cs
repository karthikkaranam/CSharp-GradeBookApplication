using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if(this.Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            var threshold = (int)Math.Ceiling(this.Students.Count * 0.2);
            var grades = this.Students.OrderByDescending(c => c.AverageGrade).Select(c => c.AverageGrade).ToList();
            if(averageGrade >= grades[threshold-1])
            {
                return 'A';
            }
            else if (averageGrade >= grades[threshold*2 - 1])
            {
                return 'B';
            }
            else if (averageGrade >= grades[threshold * 3 - 1])
            {
                return 'C';
            }
            else if (averageGrade >= grades[threshold * 4 - 1])
            {
                return 'D';
            }
            return 'F';
        }
    }
}
