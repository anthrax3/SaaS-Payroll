using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PayrollSystem.Service.WebAPI.Models.API
{
    public class APIDeduction
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

    }
}