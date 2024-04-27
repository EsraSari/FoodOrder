using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Countries: BaseClass
    {
        public string CountryName { get; set; }
        public List <Cities> City { get; set; }
        public List<AddressInformations> AddressInfo { get; set; }
    }
}
