using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Customers: BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genders Gender { get; set; }
        public int GenderID { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<AddressInformations> AddressInfo{ get; set; }
        public List<ContactInformations> ContactInfo{ get; set; }
        public List <Orders> Orders { get; set; }
    }
}
