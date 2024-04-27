using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class AddressInformations: BaseClass
    {
        public int CustomerID { get; set; }
        public Customers Customer { get; set; }
        public Countries Country { get; set; }
        public int? CountryID { get; set; }
        public Cities City { get; set; }
        public int? CityID { get; set; }
        public Counties County { get; set; }
        public int? CountyID { get; set; }
        public string AddressDetail { get; set; }
        public List<Orders> Orders { get; set; }

    }
}
