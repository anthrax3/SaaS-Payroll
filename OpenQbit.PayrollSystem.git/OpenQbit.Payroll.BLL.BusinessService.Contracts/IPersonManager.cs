using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IPersonManager
    {
        bool RecordPerson(Person person);
        bool EditPerson(Person person);
        bool RemovePerson(Person person);
        List<Person> GetAllPersons();
        Person FindPerson(Person person);
    }
}
