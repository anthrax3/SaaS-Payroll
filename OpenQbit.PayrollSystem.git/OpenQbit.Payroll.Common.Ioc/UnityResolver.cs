using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.PayrollSystem.DataAccess.DAL.Contracts;
using OpenQbit.Payroll.Common.Utils.Logs;
using OpenQbit.Payroll.DataAccess.DAL;
using OpenQbit.Payroll.BLL.BusinessService;
using OpenQbit.Payroll.BLL.BusinessService.Contracts;

namespace OpenQbit.Payroll.Common.Ioc
{
    public class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        public static void Register()
        {
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, Logger>();

            Container.RegisterType<IAdvanceManager, AdvanceManager>();
            Container.RegisterType<IAttendanceManager, AttendanceManager>();
            Container.RegisterType<IBankManager, BankManager>();
            Container.RegisterType<IBonusManager, BonusManager>();
            Container.RegisterType<IBonusTypeManager, BonusTypeManager>();
            Container.RegisterType<IDeductionManager, DeductionManager>();
            Container.RegisterType<IDepartmentManager, DepartmentManager>();
            Container.RegisterType<IEmployeeManager, EmployeeManager>();
            Container.RegisterType<IGradeManager, GradeManager>();
            Container.RegisterType<ILeavesManager, LeavesManager>();
            Container.RegisterType<ILoanManager, LoanManager>();
            Container.RegisterType<IPersonManager, PersonManager>();
            Container.RegisterType<IRoleManager, RoleManager>();
            Container.RegisterType<ISalaryManager, SalaryManager>();
            Container.RegisterType<ISystemUserManager, SystemUserManager>();

        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer getContainer()
        {
            return Container;
        }
    }
}
