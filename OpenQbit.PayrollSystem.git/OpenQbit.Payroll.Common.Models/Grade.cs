using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string GradeName { get; set; }
        public double MaxLoanAmount { get; set; }
        public double MaxAdvanceRate { get; set; }
        public double WeekEndOTAmount { get; set; }
        public double NormalOTAmount { get; set; }
        public bool VehicleAllowance { get; set; }
        public double NoPayRate { get; set; }

        public virtual ICollection<Bonus> Bonus { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual Systems System { get; set; }
    }
}
