﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class Leaves
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }
}
