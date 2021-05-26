using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public class Customer: Entity, IAggegateRoot
    {
        private CustomerId _customerid;

        public CustomerId GetCustomerId()
        {
            return _customerid;
        }

        private string _accountId;

        public Customer(string accountId, string chtName, string location)
        {
            _accountId = accountId;
            _chtName = chtName;
            _location = new DetailData(location);
            _customerid = new CustomerId(Guid.NewGuid());
        }

        public string GetAccountId()
        {
            return _accountId;
        }

        private string _chtName;

        public string GetChtName()
        {
            return _chtName;
        }
        
        private DetailData _location;

        public DetailData GetLocation()
        {
            return _location;
        }
        
        /// <summary>
        /// 檢查（帳號／身分證號）是否為特殊身分
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public bool CheckSpecialUser(string accountId)
        {
            return false;
        }

        public void ShowSpecialFlag()
        {
            
        }
    }
}
