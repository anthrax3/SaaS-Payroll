﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IBankManager
    {
        bool RecordBank(Bank bank);
        bool EditBank(Bank bank);
        bool RemoveBank(Bank bank);
        List<Bank> GetAllBank();
        Bank FindBank(Bank bank);
    }
}
