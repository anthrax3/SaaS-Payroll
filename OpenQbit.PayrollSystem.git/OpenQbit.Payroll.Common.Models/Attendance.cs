using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
   public  class Attendance
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DateTime ShortLeaveInTime { get; set; }
        public DateTime ShortLeaveOutTime { get; set; }
        public DateTime OTHourse { get; set; }

    }
}
