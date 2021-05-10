using Application.Configuration.Repositories;
using Domain.Customer;
//using Domain.Customer.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customer.GetCustomerDetailQuery
{
    public class GetCustomerDetailQuery
    {
        private ICustomerDetailRepository _customerDetailRepository;
        public GetCustomerDetailQuery(ICustomerDetailRepository customerDetailRepository)
        {
            _customerDetailRepository = customerDetailRepository;
        }

        public IEnumerable<CustomerDetailDTO> Get()
        {
            return from c in _customerDetailRepository.GetCustomers()
                   select new CustomerDetailDTO()
                   {
                       UserId = c.GetAccountId(),
                       ChtName = c.GetChtName(),
                       Location = c.GetLocation().Location
                   };
        }
    }
}
