using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollTest.Presentation.Web.Models
{
    public class SystemUser
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }


        public virtual Person Person { get; set; }
    }
}