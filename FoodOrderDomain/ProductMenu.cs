using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class ProductMenu:BaseClass
    {
        public int ProductID { get; set; }
        public Products Product { get; set; }
        public int MenuID { get; set; }
        public Menu Menu { get; set; }
        
    }
}
