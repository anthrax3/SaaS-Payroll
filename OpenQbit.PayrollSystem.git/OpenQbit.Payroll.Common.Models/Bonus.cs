using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
   public  class Bonus
    {
        public int Id { get; set; }
        public int BonusType { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

    }
}
