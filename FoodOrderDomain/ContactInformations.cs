using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class ContactInformations: BaseClass
    {
        public List<Orders> Orders{ get; set; }
        public string CommDetail { get; set; }
        public int ContactTypeID { get; set; }
        public ContactTypes ContactType  { get; set; } // cep  - email
        public int CustomerID { get; set; }
        public Customers Customer { get; set; }
    }
}
