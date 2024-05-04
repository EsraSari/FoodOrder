using FoodOrderDAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDAL.Repositories
{
    public class LoadComboBoxEntities
    {
        
        public static List<KeyValuePair<int, string>> LoadGenders(AppDBContext db)
        {
            var genders = (from gen in db.Genders
                           orderby gen.ID ascending
                           select new KeyValuePair<int, string>(gen.ID, gen.Gender)).ToList();

            return genders;
        }

        public static List<KeyValuePair<int, string>> LoadCommTypes(AppDBContext db)
        {
            var commTypes = (from com in db.ContactTypes
                           orderby com.ID ascending
                           select new KeyValuePair<int, string>(com.ID, com.ContactType)).ToList();

            return commTypes;
        }
        public static List<KeyValuePair<int, string>> LoadCategories(AppDBContext db)
        {
            var categories = (from cat in db.Categories
                              orderby cat.ID ascending
                              select new KeyValuePair<int, string>(cat.ID, cat.CategoryName)).ToList();

            return categories;
        }

        public static List<KeyValuePair<int, string>> LoadProducts(AppDBContext db)
        {
            var products = (from p in db.Products
                            orderby p.ID ascending
                            select new KeyValuePair<int, string>(p.ID, p.ProductName)).ToList();

            return products;
        }
        public static List<KeyValuePair<int, string>> LoadMenus(AppDBContext db)
        {
            var menus = (from m in db.Menu
                         orderby m.ID ascending
                         select new KeyValuePair<int, string>(m.ID, m.MenuName)).ToList();

            return menus;
        }

        public static List<KeyValuePair<int, string>> LoadCountries(AppDBContext db)
        {
            var countries = (from cs in db.Countries
                             orderby cs.ID ascending
                             select new KeyValuePair<int, string>(cs.ID, cs.CountryName)).ToList();
            return countries;
        }

        public static List<KeyValuePair<int, string>> LoadCities(AppDBContext db, int key)
        {
            var cities = (from c in db.Cities
                          orderby c.ID ascending
                          where c.CountryID == key
                          select new KeyValuePair<int, string>(c.ID, c.CityName)).ToList();
            return cities;
        }

        public static List<KeyValuePair<int, string>> LoadCounties(AppDBContext db, int key)
        {
            var counties = (from coun in db.Counties
                            orderby coun.ID ascending
                            where coun.CityID == key
                            select new KeyValuePair<int, string>(coun.ID, coun.CountyName)).ToList();

            return counties;
        }
    }
}
