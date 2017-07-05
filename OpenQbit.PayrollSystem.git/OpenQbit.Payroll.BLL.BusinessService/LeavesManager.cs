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
    public class LeavesManager : ILeavesManager
    {
        private IRepository repository;
        private ILogger logger;

        public LeavesManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordLeaves(Leaves leaves)
        {
            logger.LogError("");
            return repository.Create<Leaves>(leaves);
        }


        public bool EditLeaves(Leaves leaves)
        {
            logger.LogError("");
            return repository.Update<Leaves>(leaves);
        }

        public bool RemoveLeaves(Leaves leaves)
        {
            logger.LogError("");
            return repository.Delete<Leaves>(leaves);
        }

        public List<Leaves> GetAllLeaves()
        {
            logger.LogError("");
            return repository.GetAll<Leaves>();
        }

        public Leaves FindLeaves(Leaves leaves)
        {
            logger.LogError("");
            return repository.Find<Leaves>(A => A.Id == leaves.Id);
        }
    }
}
