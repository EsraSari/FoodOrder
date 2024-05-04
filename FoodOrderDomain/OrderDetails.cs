using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class OrderDetails: BaseClass
    {
        public int ItemType { get; set; }
        public int ItemID { get; set; }
        public Menu Menu { get; set; }
        public Products Product{ get; set; }
        public Orders Order { get; set; }
        public int OrderID { get; set; }
        
    }
}
