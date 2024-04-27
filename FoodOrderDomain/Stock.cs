using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Stock: BaseClass
    {
        public int StockAmount { get; set; }
        public bool StockStatus { get; set; } // stock amount'a göre ayarlıcaz. 
        public int ProductID { get; set; }
        public Products Product { get; set; }
        public Menu Menu { get; set; }
        public int MenuID { get; set; }
    }
}
