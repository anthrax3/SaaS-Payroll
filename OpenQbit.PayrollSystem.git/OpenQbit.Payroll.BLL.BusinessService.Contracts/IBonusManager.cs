using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IBonusManager
    {
        bool RecordBonus(Bonus bonus);
        bool EditBonus(Bonus bonus);
        bool RemoveBonus(Bonus bonus);
        List<Bonus> GetAllBonus();
        Bonus FindBonus(Bonus bonus);
    }
}
