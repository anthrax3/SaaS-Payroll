using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface ICustomerManager
    {

        bool RecordCustomer(Customer customer);
        bool EditCustomer(Customer customer);
        bool RemoveCustomer(Customer customer);
        List<Customer> GetAllCustomer();
        Customer FindAdvance(Customer customer);
    }
}
