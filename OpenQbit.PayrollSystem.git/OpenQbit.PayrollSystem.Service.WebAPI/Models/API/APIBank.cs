﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PayrollSystem.Service.WebAPI.Models.API
{
    public class APIBank
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string BankName { get; set; }
    }
}