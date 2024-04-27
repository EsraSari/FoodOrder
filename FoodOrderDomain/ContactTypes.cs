using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class ContactTypes: BaseClass
    {
        public string ContactType { get; set; }
        public List<ContactInformations> ContactInfo  { get; set; }
        
    }
}
