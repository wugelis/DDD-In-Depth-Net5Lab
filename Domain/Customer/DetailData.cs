using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public class DetailData : ValueObject
    {
        private string _myLocaton;
        public DetailData(string location)
        {
            _myLocaton = location;
        }
        public string Location 
        { 
            get
            {
                return _myLocaton;
            }
            set
            {
                _myLocaton = value;
            }
        }
    }
}
