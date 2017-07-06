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
    public class BankManager : IBankManager
    {
        private IRepository repository;
        private ILogger logger;

        public BankManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordBank(Bank bank)
        {
            logger.LogError("");
            return repository.Create<Bank>(bank);
        }

        public bool EditBank(Bank bank)
        {
            logger.LogError("");
            return repository.Update<Bank>(bank);
        }

        public bool RemoveBank(Bank bank)
        {
            logger.LogError("");
            return repository.Delete<Bank>(bank);
        }

        public List<Bank> GetAllBank()
        {
            logger.LogError("");
            return repository.GetAll<Bank>();
        }

        public Bank FindBank(Bank bank)
        {
            logger.LogError("");
            return repository.Find<Bank>(B => B.Id == bank.Id);
        }
    }
}
