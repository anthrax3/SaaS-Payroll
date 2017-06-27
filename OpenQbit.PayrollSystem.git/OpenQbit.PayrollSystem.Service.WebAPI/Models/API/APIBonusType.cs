using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PayrollSystem.Service.WebAPI.Models.API
{
    public class APIBonusType
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }

    }
}