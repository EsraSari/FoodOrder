using FoodOrderDAL.Context;
using FoodOrderDomain;
using FoodOrderDomain.Views;

namespace FoodOrderDAL.Repositories
{
    public class LoadInformations
    {

        public static List<AddressView> LoadAddressInformations(AppDBContext db, int cid)
        {
            var addressInformations = (from ad in db.AddressInformations
                                       where ad.CustomerID == cid
                                       select new AddressView
                                       {
                                           ID = ad.ID,
                                           Country = ad.Country.CountryName,
                                           City = ad.City.CityName,
                                           County = ad.County.CountyName,
                                           AddressDetail = ad.AddressDetail
                                       }).ToList();

            return addressInformations;
        }



        public static List<OrderInfo> LoadOrders(AppDBContext db, int cid)
        {
            var orders = db.Orders
				            .Where(order => order.CustomerID == cid)
							.GroupJoin(db.OrderDetails,
                                order => order.ID,
                                orderDetail => orderDetail.OrderID,
                                (order, orderDetails) => new
                                {
                                    Order = order,
                                    OrderDetails = orderDetails
                                })
                            .SelectMany(
                                join => join.OrderDetails.DefaultIfEmpty(),
                                (join, orderDetail) => new { Order = join.Order, OrderDetail = orderDetail })
                            .GroupBy(x => x.Order.ID)
                            .Select(group => new OrderInfo
                            {
                                OrderID = group.Key,
                                OrderPrice = group.First().Order.Price,
                                OrderState = group.First().Order.OrderState.OrderState,
                                OrderDetail = string.Join(", ", group.Select(x =>
                                    $"{x.OrderDetail.ItemID}-{(x.OrderDetail.ItemTypeID == 1 ? (db.Products.FirstOrDefault(p => p.ID == x.OrderDetail.ItemID) != null ? db.Products.FirstOrDefault(p => p.ID == x.OrderDetail.ItemID).ProductName : "Bilgi yok") : (x.OrderDetail.ItemTypeID == 2 ? (db.Menu.FirstOrDefault(m => m.ID == x.OrderDetail.ItemID) != null ? db.Menu.FirstOrDefault(m => m.ID == x.OrderDetail.ItemID).MenuName : "Bilgi yok") : "Bilgi yok"))}"))
                            })
                            .ToList();

            return orders;
        }

        public static List<ContactInfoView> LoadCommunicationInformations(AppDBContext db, int cid)
        {
            var commInformations = (from cc in db.ContactInformations
                                       where cc.CustomerID == cid
                                       select new ContactInfoView
                                       {
                                           ID = cc.ID,
                                           //ContactTypeID = cc.ContactTypeID,
                                           ContactType = cc.ContactType.ContactType,
                                           CommDetail = cc.CommDetail
                                       }).ToList();

            return commInformations;
        }
    }
    public class OrderInfo
    {
        public int OrderID { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderState { get; set; }
        public string OrderDetail { get; set; }
    }
}
