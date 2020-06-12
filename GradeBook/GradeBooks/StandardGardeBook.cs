using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGardeBook : BaseGradeBook
    {
        public StandardGardeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
