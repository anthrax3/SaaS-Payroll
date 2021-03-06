﻿using System;
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
    public class BonusTypeManager : IBonusTypeManager
    {

        private IRepository repository;
        private ILogger logger;

        public BonusTypeManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordBonusType(BonusType bonusType)
        {
            logger.LogError("");
            return repository.Create<BonusType>(bonusType);
        }

        public bool EditBonusType(BonusType bonusType)
        {
            logger.LogError("");
            return repository.Update<BonusType>(bonusType);
        }

        public bool RemoveBonusType(BonusType bonusType)
        {
            logger.LogError("");
            return repository.Delete<BonusType>(bonusType);

        }

        public List<BonusType> GetAllBonusType()
        {
            logger.LogError("");
            return repository.GetAll<BonusType>();
        }

        public BonusType FindBonusType(BonusType bonusType)
        {
            logger.LogError("");
            return repository.Find<BonusType>(B => B.Id == bonusType.Id);
        }
    }
}
