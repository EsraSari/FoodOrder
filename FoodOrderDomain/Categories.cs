using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Categories
    {
        public string CategoryName { get; set; }
        public List <Products> Product { get; set; } // bir kategoride birden fazla ürün olabilir.
    }
}
