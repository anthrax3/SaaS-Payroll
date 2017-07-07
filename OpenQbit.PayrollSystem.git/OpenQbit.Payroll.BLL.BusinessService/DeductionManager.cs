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
    public class DeductionManager : IDeductionManager
    {
        private IRepository repository;
        private ILogger logger;

        public DeductionManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public bool RecordDeduction(Deduction deduction)
        {
            logger.LogError("");
            return repository.Create<Deduction>(deduction);
        }


        public bool EditDeduction(Deduction deduction)
        {
            logger.LogError("");
            return repository.Update<Deduction>(deduction);
        }

        public bool RemoveDeduction(Deduction deduction)
        {
            logger.LogError("");
            return repository.Delete<Deduction>(deduction);
        }

        public List<Deduction> GetAllDeductions()
        {
            logger.LogError("");
            return repository.GetAll<Deduction>();
        }

        public Deduction FindDeduction(Deduction deduction)
        {
            logger.LogError("");
            return repository.Find<Deduction>(A => A.Id == deduction.Id);
        }
    }
}
