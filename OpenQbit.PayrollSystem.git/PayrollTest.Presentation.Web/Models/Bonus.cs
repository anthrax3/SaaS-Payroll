using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollTest.Presentation.Web.Models
{
    public class Bonus
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int GradeId { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public virtual BonusType BonusType { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Systems System { get; set; }
    }
}