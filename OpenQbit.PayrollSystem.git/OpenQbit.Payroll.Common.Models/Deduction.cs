using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class Deduction
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double DamageCost { get; set; }
        public double MonthlyDeduction { get; set; }
        public string TimePeriod { get; set; }
        public DateTime DueDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Systems System { get; set; }
    }
}
