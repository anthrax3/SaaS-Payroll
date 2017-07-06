using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface ISystemUserManager
    {
        bool RecordSystemUser(SystemUser systemUser);
        bool EditSystemUser(SystemUser systemUser);
        bool RemoveSystemUser(SystemUser systemUser);
        List<SystemUser> GetAllSystemUser();
        SystemUser FindSystemUser(SystemUser systemUser);
    }
}
