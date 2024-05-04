using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class ItemTypes:BaseClass
    {
        public string ItemName { get; set; }
        public List<OrderDetails> OrderDetails{ get; set; }
    }
}
