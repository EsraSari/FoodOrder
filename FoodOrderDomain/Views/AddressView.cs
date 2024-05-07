using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain.Views
{
    public class AddressView
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string County {get; set; }
        public string AddressDetail { get; set; }
    }
}
