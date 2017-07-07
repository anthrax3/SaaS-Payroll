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
    public class SystemsManager : ISystemsManager
    {

        public SystemsManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        private IRepository repository;
        private ILogger logger;

        public bool RecordSystems(Systems system)
        {
            logger.LogError("");
            return repository.Create<Systems>(system);
        }

        public bool EditSystems(Systems system)
        {
            logger.LogError("");
            return repository.Update<Systems>(system);
        }

        public bool RemoveSystems(Systems system)
        {
            logger.LogError("");
            return repository.Delete<Systems>(system);
        }

        public List<Systems> GetAllSystems()
        {
            logger.LogError("");
            return repository.GetAll<Systems>();
        }

        public Systems FindAdvance(Systems system)
        {
            logger.LogError("");
            return repository.Find<Systems>(S => S.SystemId == system.SystemId);
        }
    }
}
