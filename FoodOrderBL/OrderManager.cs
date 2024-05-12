using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using FoodOrderDomain.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class OrderManager
    {
        private readonly AppDBContext _db;
        private readonly int _key;

        public OrderManager()
        {
            _db = new AppDBContext();
        }

        public OrderManager(int key)
        {   
            _db = new AppDBContext();
            _key = key;
        }

        public bool UpdateOrder(int orderID)
        {
            try
            {
                var order = _db.Orders.FirstOrDefault(x => x.ID == orderID);
                if (order != null)
                {
                    order.OrderStateID = 3;
                    _db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool CreateOrder(int customerID, int addressID, int contactID, decimal price, string orderNotes, List<OrderItems> orderItems)
        {
            try
            {
                Orders order = new Orders()
                {
                    CustomerID = customerID,
                    AddressID = addressID,
                    ContactID = contactID,
                    OrderStateID = 1,
                    PaymentMethodID = 1,
                    PaymentStatus = true,
                    Price = price,
                    OrderNotes = orderNotes
                };

                _db.Orders.Add(order);

                
                foreach (var orderItem in orderItems)
                {
                    OrderDetails orderDetail = new OrderDetails()
                    {
                        Order = order,
                        ItemTypeID = orderItem.TypeID,
                        ItemID = orderItem.ID,
                        Amount = orderItem.Amount
                    };
                    _db.OrderDetails.Add(orderDetail);
                }

                _db.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public List<OrderInfo> GetOrders()
        {
            if (_db != null)
            {
                return LoadInformations.LoadOrders(_db, _key);
            }
            return null;
        }
    }
}
