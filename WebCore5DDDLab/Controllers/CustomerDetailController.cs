using Application.Customer;
using Application.Customer.GetCustomerDetailQuery;
using Application.Customer.RegisterCustomer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore5DDDLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDetailController : ControllerBase
    {
        private GetCustomerDetailQuery _getCustomerDetailQuery;
        private CustomerBasicDetailRegisterHandler _customerBasicDetailRegisterHandler;
        public CustomerDetailController(GetCustomerDetailQuery getCustomerDetailQuery, CustomerBasicDetailRegisterHandler customerBasicDetailRegisterHandler)
        {
            _getCustomerDetailQuery = getCustomerDetailQuery;
            _customerBasicDetailRegisterHandler = customerBasicDetailRegisterHandler;
        }

        [HttpGet]
        public IEnumerable<CustomerDetailDTO> Get()
        {
            return _getCustomerDetailQuery.Get();
        }

        [HttpPost]
        public int AddBasicCustomerDetailData(CustomerDetailDTO customerDetail)
        {
            return _customerBasicDetailRegisterHandler.AddCustomerDetailData(customerDetail);
        }
    }
}
