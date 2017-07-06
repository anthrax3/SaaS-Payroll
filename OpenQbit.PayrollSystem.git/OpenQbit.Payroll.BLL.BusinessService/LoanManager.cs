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
    public class LoanManager : ILoanManager
    {
        private IRepository repository;
        private ILogger logger;

        public LoanManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordLoan(Loan loan)
        {
            logger.LogError("");
            return repository.Create<Loan>(loan);
        }

        public bool EditLoan(Loan loan)
        {
            logger.LogError("");
            return repository.Update<Loan>(loan);
        }

        public bool RemoveLoan(Loan loan)
        {
            logger.LogError("");
            return repository.Delete<Loan>(loan);
        }

        public List<Loan> GetAllLoans()
        {
            logger.LogError("");
            return repository.GetAll<Loan>();
        }

        public Loan FindLoan(Loan loan)
        {
            logger.LogError("");
            return repository.Find<Loan>(L => L.Id == loan.Id);
        }
    }
}
