using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models.System
{
    public class Systems
    {
        public int SystemId { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }


    }
}
