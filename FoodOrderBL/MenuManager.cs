using FoodOrderDAL.Context;
using FoodOrderDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class MenuManager
    {
        private AppDBContext _db;
        public MenuManager()
        {
            _db = new AppDBContext();
        }

        public bool CreateMenu(string menuName, int prepTime, bool isAllergen, decimal price, List<int> selectedProductIds)
        {
            try
            {
                Menu menu = new Menu()
                {
                    MenuName = menuName,
                    IsAllergen = isAllergen,
                    PreparationTime = prepTime,
                    Price = price
                };

                _db.Menu.Add(menu);

                foreach (int productId in selectedProductIds)
                {
                    ProductMenu productMenu = new ProductMenu
                    {
                        Menu = menu,
                        ProductID = productId
                    };

                    _db.ProductMenu.Add(productMenu);
                }

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

