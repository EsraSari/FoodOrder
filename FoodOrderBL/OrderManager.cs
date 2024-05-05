using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
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
