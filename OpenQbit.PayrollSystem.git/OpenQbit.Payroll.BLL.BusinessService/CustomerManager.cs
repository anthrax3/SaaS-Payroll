using OpenQbit.Payroll.BLL.BusinessService.Contracts;
using OpenQbit.Payroll.Common.Models.System;
using OpenQbit.Payroll.Common.Utils.Logs;
using OpenQbit.Payroll.DataAccess.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.BLL.BusinessService
{
    public class CustomerManager : ICustomerManager
    {
        private IRepository repository;
        private ILogger logger;

        public CustomerManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public bool RecordCustomer(Customer customer)
        {
            logger.LogError("");
            return repository.Create<Customer>(customer);
        }

        public bool EditCustomer(Customer customer)
        {
            logger.LogError("");
            return repository.Update<Customer>(customer);
        }

        public bool RemoveCustomer(Customer customer)
        {
            logger.LogError("");
            return repository.Delete<Customer>(customer);
        }

        public List<Customer> GetAllCustomer()
        {
            logger.LogError("");
            return repository.GetAll<Customer>();
        }

        public Customer FindAdvance(Customer customer)
        {
            logger.LogError("");
            return repository.Find<Customer>(C => C.CustomerId == customer.CustomerId);
        }
    }
}
