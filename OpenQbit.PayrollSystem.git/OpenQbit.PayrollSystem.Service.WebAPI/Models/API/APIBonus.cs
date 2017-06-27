using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PayrollSystem.Service.WebAPI.Models.API
{
    public class APIBonus
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int GradeId { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

    }
}