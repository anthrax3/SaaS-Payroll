﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollTest.Presentation.Web.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public double Transport { get; set; }
        public double OT { get; set; }
        public double Tax { get; set; }
        public double EPF { get; set; }
        public double EF { get; set; }
        public double NoPay { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Systems System { get; set; }
    }
}