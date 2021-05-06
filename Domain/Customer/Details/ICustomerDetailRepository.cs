using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer.Details
{
    public interface ICustomerDetailRepository
    {
        IEnumerable<Customer> GetCustomers();
        int AddBasicCustomerDetailData(Customer customer);
    }
}
