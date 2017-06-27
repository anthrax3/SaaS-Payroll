using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PayrollSystem.Service.WebAPI.Models.API
{
    public class APILoan
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public double LoanAmount { get; set; }
        public double MonthlyInstallement { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueTime { get; set; }
        public double TimePeriod { get; set; }
        public string Description { get; set; }
        public string GuaranterName { get; set; }
        public string GuaranterNic { get; set; }
        public int GuaranterMobile { get; set; }
    }
}