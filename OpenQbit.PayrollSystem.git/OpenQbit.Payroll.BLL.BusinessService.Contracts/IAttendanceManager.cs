using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IAttendanceManager
    {
        bool RecordAttendance(Attendance attendance);
        bool EditAttendance(Attendance attendance);
        bool RemoveAttendance(Attendance attendance);
        List<Attendance> GetAllAttendance();
        Attendance FindAttendance(Attendance attendance);
    }
}
