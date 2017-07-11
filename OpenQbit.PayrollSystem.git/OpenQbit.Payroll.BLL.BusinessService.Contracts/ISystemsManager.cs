using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.BLL.BusinessService
{
    public interface ISystemsManager
    {

        bool RecordSystems(Systems system);
        bool EditSystems(Systems system);
        bool RemoveSystems(Systems system);
        List<Systems> GetAllSystems();
        Systems FindAdvance(Systems system);
    }
}
