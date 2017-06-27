using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PayrollSystem.Service.WebAPI.Models.API
{
    public class APIAdvance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public double Aount { get; set; }

    }
}