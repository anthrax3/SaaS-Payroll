﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface ILoanManager
    {
        bool RecordLoan(Loan loan);
        bool EditLoan(Loan loan);
        bool RemoveLoan(Loan loan);
        List<Loan> GetAllLoans();
        Loan FindLoan(Loan loan);
    }
}
