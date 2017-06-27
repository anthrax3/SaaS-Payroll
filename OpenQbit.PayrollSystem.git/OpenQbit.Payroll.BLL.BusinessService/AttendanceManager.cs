using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.BLL.BusinessService.Contracts;
using OpenQbit.Payroll.Common.Models;
using OpenQbit.Payroll.Common.Utils.Logs;
using OpenQbit.PayrollSystem.DataAccess.DAL.Contracts;

namespace OpenQbit.Payroll.BLL.BusinessService
{
    public class AttendanceManager : IAttendanceManager
    {

        private IRepository repository;
        private ILogger logger;

        public AttendanceManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public bool RecordAttendance(Attendance attendance)
        {
            logger.LogError("");
            return repository.Create<Attendance>(attendance);
        }
    }
}
