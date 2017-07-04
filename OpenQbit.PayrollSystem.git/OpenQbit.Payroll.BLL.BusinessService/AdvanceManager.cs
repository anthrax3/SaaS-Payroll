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
    public class AdvanceManager : IAdvanceManager
    {

        private IRepository repository;
        private ILogger logger;

        public AdvanceManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }


        public bool RecordAdvance(Advance advance)
        {
            logger.LogError("");
            return repository.Create<Advance>(advance);
        }

        public bool EditAdavance(Advance advance)
        {
            logger.LogError("");
            return repository.Update<Advance>(advance);
        }

        public bool RemoveAdvance(Advance advance)
        {
            logger.LogError("");
            return repository.Delete<Advance>(advance);
        }

        public List<Advance> GetAllAdvances()
        {
            logger.LogError("");
            return repository.GetAll<Advance>();
        }

        public Advance FindAdvance(Advance advance)
        {
            logger.LogError("");
            return repository.Find<Advance>(A => A.Id == advance.Id);
        }
    }
}
