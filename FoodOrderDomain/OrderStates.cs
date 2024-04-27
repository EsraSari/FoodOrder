using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class OrderStates : BaseClass
    {
        public string OrderState{ get; set; }
        public List<Orders> Orders { get; set; }
    }
}
