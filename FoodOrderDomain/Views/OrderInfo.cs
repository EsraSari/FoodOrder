using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain.Views
{
	public class OrderInfo
	{
		public int OrderID { get; set; }
		public decimal OrderPrice { get; set; }
		public string OrderState { get; set; }
		public string OrderDetail { get; set; }
	}
}
