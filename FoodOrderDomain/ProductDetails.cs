using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class ProductDetails : BaseClass
    {
        public int ProductID { get; set; }
        public Products Product { get; set; }
        public string Description { get; set; }
    }
}
