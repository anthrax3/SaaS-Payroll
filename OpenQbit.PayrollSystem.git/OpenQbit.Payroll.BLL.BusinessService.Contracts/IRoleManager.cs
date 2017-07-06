using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IRoleManager
    {
        bool RecordRole(Role role);
       
        bool EditRole(Role role);
        bool RemoveRole(Role role);
        List<Role> GetAllRoles();
        Role FindRole(Role role);
    }
}
