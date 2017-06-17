using OpenQbit.Payroll.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.DataAccess.DAL
{
    public class PayrollContext : DbContext
    {
        public PayrollContext() : base("PayrollDatabase")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Person> dbPerson { get; set; }
        public DbSet<Employee> dbEmployee { get; set; }
        public DbSet<SystemUser> dbSystemUser { get; set; }
        public DbSet<Role> dbRole { get; set; }
        public DbSet<Department> dbDepartment { get; set; }
        public DbSet<Grade> dbGrade { get; set; }
        public DbSet<Attendance> dbAttendance { get; set; }
        public DbSet<Advance> dbAdvance { get; set; }
        public DbSet<Loan> dbLone { get; set; }
        public DbSet<Deduction> dbDeduction { get; set; }
        public DbSet<Leaves> dbLeaves{ get; set; }
        public DbSet<BonusType> dbAttendance { get; set; }
        public DbSet<Bonus> dbBonus { get; set; }

    }
}
