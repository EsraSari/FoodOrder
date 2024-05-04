using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class Orders:BaseClass
    {
        public int? CustomerID { get; set; }
        public Customers Customer { get; set; }
        public int AddressID { get; set; }
        public AddressInformations Address { get; set; }
        public int? ContactID { get; set; }
        public ContactInformations ContactInfo { get; set; }
        public int OrderStateID { get; set; }  // "Hazırlanıyor", "Teslim Edildi", "İptal Edildi"
        public OrderStates OrderState { get; set; } // "Hazırlanıyor", "Teslim Edildi", "İptal Edildi"
        public decimal Price { get; set; }
        public bool PaymentStatus { get; set; } // Ödendi Ödenmedi
        public int PaymentMethodID { get; set; } // kredi kart , nakit
        public PaymentMethods PaymentMethod { get; set; }
        public string OrderNotes { get; set; } // siparişle ilgili not.
        public List<OrderDetails> OrderDetails { get; set; }
    }

}
