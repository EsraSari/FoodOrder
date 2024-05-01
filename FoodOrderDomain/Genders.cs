using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Genders: BaseClass
    {
        public string Gender { get; set; }
        public List<Customers> Customers{ get; set; }
    }
}
