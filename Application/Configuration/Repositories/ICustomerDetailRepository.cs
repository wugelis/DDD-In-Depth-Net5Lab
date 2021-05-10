using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDomain = global::Domain.Customer;

namespace Application.Configuration.Repositories
{
    public interface ICustomerDetailRepository
    {
        IEnumerable<CustomerDomain.Customer> GetCustomers();
        int AddBasicCustomerDetailData(CustomerDomain.Customer customer);
    }
}
