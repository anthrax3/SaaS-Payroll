using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
        public int GradeId { get; set; }
        public int RoleId { get; set; }
        public int BankId { get; set; }
        public string BankAccount { get; set; }
        public DateTime JoinedDate { get; set; }


        public virtual Person Person { get; set; }
        public virtual Department Department { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Role Role { get; set; }
        public virtual Bank Bank { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<Salary> Salary { get; set; }
        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<Advance> Advance { get; set; }
        public virtual ICollection<Deduction> Deduction { get; set; }
        public virtual ICollection<Leaves> Leaves { get; set; }


    }
}
