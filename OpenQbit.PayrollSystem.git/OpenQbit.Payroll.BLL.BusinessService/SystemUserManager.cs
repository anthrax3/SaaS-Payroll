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
    public class SystemUserManager : ISystemUserManager
    {
        private IRepository repository;
        private ILogger logger;

        public SystemUserManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordSystemUser(SystemUser systemUser)
        {
            logger.LogError("");
            return repository.Create<SystemUser>(systemUser);
        }

        public bool EditSystemUser(SystemUser systemUser)
        {
            logger.LogError("");
            return repository.Update<SystemUser>(systemUser);
        }

        public bool RemoveSystemUser(SystemUser systemUser)
        {
            logger.LogError("");
            return repository.Delete<SystemUser>(systemUser);
        }

        public List<SystemUser> GetAllSystemUser()
        {
            logger.LogError("");
            return repository.GetAll<SystemUser>();
        }

        public SystemUser FindSystemUser(SystemUser systemUser)
        {
            logger.LogError("");
            return repository.Find<SystemUser>(S => S.Id == systemUser.Id);
        }
    }
}
