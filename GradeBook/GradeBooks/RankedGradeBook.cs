using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

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
            switch (averageGrade)
            {
                case double grade when grade >= 20:
                    {
                        return 'A';
                    }
                case double grade when grade > 20 & grade <= 40:
                    {
                        return 'B';
                    }
                case double grade when grade > 40 & grade <= 60:
                    {
                        return 'C';
                    }
                case double grade when grade > 60 & grade <= 80:
                    {
                        return 'D';
                    }
            }
            return 'F';
        }
    }
}
