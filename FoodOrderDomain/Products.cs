using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Products: BaseClass
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public Categories Category { get; set; }

        [ForeignKey("Stock")]
        public int StockID { get; set; }
        public Stock Stock { get; set; }
        public decimal Price { get; set; }
        public DateTime PreparationTime { get; set; }

        [ForeignKey("ProductDetails")]
        public int ProductDetailID { get; set; }
        public ProductDetails ProductDetail { get; set; }
        

    }
}
