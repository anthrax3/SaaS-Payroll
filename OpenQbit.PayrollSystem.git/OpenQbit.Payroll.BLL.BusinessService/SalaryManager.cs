using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.BLL.BusinessService.Contracts;
using OpenQbit.Payroll.Common.Models;
using OpenQbit.Payroll.Common.Utils.Logs;
using OpenQbit.PayrollSystem.DataAccess.DAL.Contracts;

namespace OpenQbit.Payroll.BLL.BusinessService
{ 
    public class SalaryManager : ISalaryManager
    {
        private IRepository repository;
        private ILogger logger;

        public SalaryManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordSalary(Salary salary)
        {
            logger.LogError("");
            return repository.Create<Salary>(salary);
        }
    }
}
