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

        public bool EditAttendance(Attendance attendance)
        {
            logger.LogError("");
            return repository.Update<Attendance>(attendance);
        }

        public bool RemoveAttendance(Attendance attendance)
        {
            logger.LogError("");
            return repository.Delete(attendance);
        }

        public List<Attendance> GetAllAttendance()
        {
            logger.LogError("");
            return repository.GetAll<Attendance>();
        }

        public Attendance FindAttendance(Attendance attendance)
        {
            logger.LogError("");
            return repository.Find<Attendance>(A => A.Id == attendance.Id);
        }
    }
}
