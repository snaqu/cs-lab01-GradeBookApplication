using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name, Boolean isWeighted) : base(name, isWeighted)
        {
            this.Type = Enums.GradeBookType.Standard;
        }
    }
}
