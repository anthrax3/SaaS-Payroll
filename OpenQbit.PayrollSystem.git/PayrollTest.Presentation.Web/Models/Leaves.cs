﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollTest.Presentation.Web.Models
{
    public class Leaves
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}