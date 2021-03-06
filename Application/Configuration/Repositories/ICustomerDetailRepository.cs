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
        int Save(CustomerDomain.Customer customer);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        CustomerDomain.Customer Get(string guid);
    }
}
