﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IBonusTypeManager
    {
        bool RecordBonusType(BonusType bonusType);
        bool EditBonusType(BonusType bonusType);
        bool RemoveBonusType(BonusType bonusType);
        List<BonusType> GetAllBonusType();
        BonusType FindBonusType(BonusType bonusType);
    }
}
