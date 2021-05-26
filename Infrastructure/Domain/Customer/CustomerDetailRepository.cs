using Application.Configuration.Repositories;
//using Domain.Customer.Details;
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
        public int Save(global::Domain.Customer.Customer customer)
        {
            _customers.Add(customer);
            return 1;
        }

        public global::Domain.Customer.Customer Get(string guid)
        {
            return _customers.Where(c => c.GetCustomerId().Value.ToString() == guid)
                .FirstOrDefault();
        }

        public IEnumerable<global::Domain.Customer.Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
