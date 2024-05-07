using FoodOrderDAL.Context;
using FoodOrderDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class ProductManager
    {
        private AppDBContext _db;
        public ProductManager()
        {
            _db = new AppDBContext();
        }

        public bool CreateProduct(string productName, decimal price, int catID, int prepTime)
        {
            try
            {
                Products product = new Products()
                {
                    ProductName = productName,
                    Price = price,
                    CategoryID = catID,
                    PreparationTime = prepTime,
                };
                _db.Products.Add(product);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
