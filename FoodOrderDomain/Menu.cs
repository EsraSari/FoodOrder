using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Menu:BaseClass
    {
        public string MenuName { get; set; }
        public int PreparationTime { get; set; }
        public bool IsAllergen { get; set; }// burada menüye eklenen ürünlerin totali olarak yansıtıcaz.
        public decimal Price { get; set; }// burada menüye eklenen ürünlerin totali olarak yansıtıcaz.
        public Stock Stock { get; set; }
        public List<OrderDetails> OrderDetails{ get; set; }
    }
}
