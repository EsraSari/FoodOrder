using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Counties: BaseClass // ilçe
    {
        public int CityID { get; set; }
        public Cities City { get; set; }
        public string CountyName { get; set; }
        public List<AddressInformations> AddressInfo { get; set; }
    }
}
