using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class AddressManager
    {
        private readonly AppDBContext _db;
        private readonly int _key;
        public AddressManager()
        {
            _db = new AppDBContext();
        }
        public AddressManager(int key)
        {
            _db = new AppDBContext();
            _key = key;
        }
        public bool CreateAddress(int country, int city, int county, string addressdetail, int customerID)
        {
            try
            {
                var address = new AddressInformations
                {
                    CountryID = country,
                    CityID = city,
                    CountyID = county,
                    AddressDetail = addressdetail,
                    CustomerID = customerID,
                    Status = true,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };
                _db.AddressInformations.Add(address);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<AddressInformations> GetAddressInfo()
        {
            if (_db != null)
            {
                return LoadInformations.LoadAddressInformations(_db, _key);
            }
            return null;
        }

    }
}
