using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Payroll.Service.WebAPI.Models.API
{
    public class APIGrade
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

    }
}