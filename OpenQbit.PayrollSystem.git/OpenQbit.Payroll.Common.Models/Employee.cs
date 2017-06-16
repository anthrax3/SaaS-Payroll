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
        public string BankAccount { get; set; }
        public DateTime JoinedDate { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

    }
}
