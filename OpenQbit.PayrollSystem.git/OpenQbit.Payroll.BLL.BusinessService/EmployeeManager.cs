using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.BLL.BusinessService.Contracts;
using OpenQbit.Payroll.Common.Models;
using OpenQbit.Payroll.Common.Utils.Logs;
using OpenQbit.Payroll.DataAccess.DAL.Contracts;

namespace OpenQbit.Payroll.BLL.BusinessService
{
    public class EmployeeManager : IEmployeeManager
    {
        private IRepository repository;
        private ILogger logger;

        public EmployeeManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordEmployee(Employee employee)
        {
            logger.LogError("");
            return repository.Create<Employee>(employee);
        }
    }
}
