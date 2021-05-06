using Domain.Customer.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain.Customer
{
    public class CustomerDetailRepository : ICustomerDetailRepository
    {
        private static List<global::Domain.Customer.Customer> _customers = new List<global::Domain.Customer.Customer>();
        public int AddBasicCustomerDetailData(global::Domain.Customer.Customer customer)
        {
            _customers.Add(customer);
            return 1;
        }

        public IEnumerable<global::Domain.Customer.Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
