//using Domain.Customer.Details;
using CustomerDetail = global::Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Configuration.Repositories;
using Domain.Customer;

namespace Application.Customer.RegisterCustomer
{
    public class CustomerBasicDetailRegisterHandler
    {
        public CustomerBasicDetailRegisterHandler(ICustomerDetailRepository customerDetailRepository)
        {
            _customerDetailRepository = customerDetailRepository;
        }

        private ICustomerDetailRepository _customerDetailRepository { get; }

        public int AddCustomerDetailData(CustomerDetailDTO customerDeatil)
        {
            CustomerDetail.Customer customer = new CustomerDetail.Customer();
            customer.SetAccountId(customerDeatil.UserId);
            customer.SetChtName(customerDeatil.ChtName);
            customer.SetLocation(new DetailData(customerDeatil.Location));

            // Process and others..
            return _customerDetailRepository.AddBasicCustomerDetailData(customer);
        }
    }
}
