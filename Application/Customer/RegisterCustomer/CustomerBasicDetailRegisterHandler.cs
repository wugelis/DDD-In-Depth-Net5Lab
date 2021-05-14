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
        public CustomerBasicDetailRegisterHandler(
            ICustomerDetailRepository customerDetailRepository, 
            CustomerService customerService)
        {
            _customerDetailRepository = customerDetailRepository;
            _customerService = customerService;
        }

        private ICustomerDetailRepository _customerDetailRepository;
        private CustomerService _customerService;

        public int AddCustomerDetailData(CustomerDetailDTO customerDeatil)
        {
            CustomerDetail.Customer customer = _customerDetailRepository.Get();
            customer.SetAccountId(customerDeatil.UserId);
            customer.SetChtName(customerDeatil.ChtName);
            customer.SetLocation(new DetailData(customerDeatil.Location));

            // 檢查（帳號／身分證號）是否為特殊身分
            _customerService.CheckIsSpecialAccount(customer, customerDeatil.UserId);

            // Process and others..
            return _customerDetailRepository.Save(customer);
        }
    }
}
