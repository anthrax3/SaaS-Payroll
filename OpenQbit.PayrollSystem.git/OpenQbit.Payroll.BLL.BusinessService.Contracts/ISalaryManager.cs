using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface ISalaryManager
    {
        bool RecordSalary(Salary salary);
        bool EditSalary(Salary salary);
        bool RemoveSalary(Salary salary);
        List<Salary> GetAllSalary();
        Salary FindSalary(Salary salary);

    }
}
