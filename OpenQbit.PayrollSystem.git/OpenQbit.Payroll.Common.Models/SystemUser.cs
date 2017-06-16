using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class SystemUser 
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

    }
}
