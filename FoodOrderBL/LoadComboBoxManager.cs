using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{

    public class LoadComboBoxManager
    {
        private readonly AppDBContext _db;
        private readonly int _key;
        public LoadComboBoxManager(AppDBContext db)
        {
            _db = db;
        }
        public LoadComboBoxManager(AppDBContext db, int key)
        {
            _db = db;
            _key = key;
        }
        public List<KeyValuePair<int, string>> LoadGenders()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadGenders(_db);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadCommTypes()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadCommTypes(_db);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadCategories()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadCategories(_db);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadProducts()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadProducts(_db);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadMenus()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadMenus(_db);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadCountries()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadCountries(_db);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadCities()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadCities(_db,_key);
            }
            return null;
        }
        public List<KeyValuePair<int, string>> LoadCounties()
        {
            if (_db != null)
            {
                return LoadComboBoxEntities.LoadCounties(_db, _key);
            }
            return null;
        }
    }
}
