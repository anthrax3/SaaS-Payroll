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
    public class DepartmentManager : IDepartmentManager
    {
        private IRepository repository;
        private ILogger logger;

        public DepartmentManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordDepartment(Department department)
        {
            logger.LogError("");
            return repository.Create<Department>(department);
        }


        public bool EditDepartment(Department department)
        {
            logger.LogError("");
            return repository.Update<Department>(department);
        }

        public bool RemoveDepartment(Department department)
        {
            logger.LogError("");
            return repository.Delete<Department>(department);
        }

        public List<Department> GetAllDepartments()
        {
            logger.LogError("");
            return repository.GetAll<Department>();
        }

        public Department FindDepartment(Department department)
        {
            logger.LogError("");
            return repository.Find<Department>(A => A.Id == department.Id);
        }
    }
}
