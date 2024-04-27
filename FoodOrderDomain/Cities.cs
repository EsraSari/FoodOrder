using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Cities: BaseClass
    {
        public string CityName { get; set; }
        public int CountryID { get; set; }
        public Countries Country { get; set; }
        public List<Counties> County { get; set; }
        public List<AddressInformations> AddressInfo { get; set; }
    }
}
