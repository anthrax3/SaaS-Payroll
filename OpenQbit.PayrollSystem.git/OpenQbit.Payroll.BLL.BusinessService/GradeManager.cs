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
    public class GradeManager : IGradeManager
    {
        private IRepository repository;
        private ILogger logger;

        public GradeManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordGrade(Grade grade)
        {
            logger.LogError("");
            return repository.Create<Grade>(grade);
        }


        public bool EditGrade(Grade grade)
        {
            logger.LogError("");
            return repository.Update<Grade>(grade);
        }

        public bool RemoveGrade(Grade grade)
        {
            logger.LogError("");
            return repository.Delete<Grade>(grade);
        }

        public List<Grade> GetAllGrades()
        {
            logger.LogError("");
            return repository.GetAll<Grade>();
        }

        public Grade FindGrade(Grade grade)
        {
            logger.LogError("");
            return repository.Find<Grade>(A => A.Id == grade.Id);
        }
    }
}
