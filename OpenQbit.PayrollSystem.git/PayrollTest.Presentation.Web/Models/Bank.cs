using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollTest.Presentation.Web.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string BankName { get; set; }
        //public virtual Employee Employee { get; set; }

        public virtual Systems System { get; set; }
    }
}