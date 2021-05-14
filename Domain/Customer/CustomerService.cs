using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public class CustomerService
    {
        public CustomerService()
        {
        }

        /// <summary>
        /// 檢查是否為特出身分使用者
        /// 可能呼叫機關提供之服務以檢查是否為特殊身分國民
        /// </summary>
        /// <param name="customer">客戶物件實體</param>
        /// <param name="accountId">可能是身份證字號</param>
        /// <returns></returns>
        public void CheckIsSpecialAccount(Customer customer, string accountId)
        {
            bool isSpecial = customer.CheckSpecialUser(accountId);

            if (isSpecial)
            {
                customer.ShowSpecialFlag();
            }
        }
    }
}
