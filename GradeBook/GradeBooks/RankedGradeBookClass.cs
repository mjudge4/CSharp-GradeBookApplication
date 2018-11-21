using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBookClass : BaseGradeBook
    {
        public RankedGradeBookClass(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
