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
    public class BonusManager : IBonusManager
    {
        private IRepository repository;
        private ILogger logger;

        public BonusManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordBonus(Bonus bonus)
        {
            logger.LogError("");
            return repository.Create<Bonus>(bonus);
        }

        public bool EditBonus(Bonus bonus)
        {
            logger.LogError("");
            return repository.Update<Bonus>(bonus);
        }

        public bool RemoveBonus(Bonus bonus)
        {
            logger.LogError("");
            return repository.Delete<Bonus>(bonus);
        }

        public List<Bonus> GetAllBonus()
        {
            logger.LogError("");
            return repository.GetAll<Bonus>();
        }

        public Bonus FindBonus(Bonus bonus)
        {
            logger.LogError("");
            return repository.Find<Bonus>(B => B.Id == bonus.Id);
        }
    }
}
