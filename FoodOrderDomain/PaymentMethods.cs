using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class PaymentMethods:BaseClass
    {
        public string PaymentName { get; set; }
        public List <Orders> Orders{ get; set; }
    }
}
