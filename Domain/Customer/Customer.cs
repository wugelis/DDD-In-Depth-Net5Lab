using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public class Customer: Entity, IAggegateRoot
    {
        private string accountId;

        public string GetAccountId()
        {
            return accountId;
        }

        public void SetAccountId(string value)
        {
            accountId = value;
        }

        private string chtName;

        public string GetChtName()
        {
            return chtName;
        }

        public void SetChtName(string value)
        {
            chtName = value;
        }

        private DetailData location;

        public DetailData GetLocation()
        {
            return location;
        }

        public void SetLocation(DetailData value)
        {
            location = value;
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
