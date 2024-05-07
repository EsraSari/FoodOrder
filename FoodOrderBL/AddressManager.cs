using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using FoodOrderDomain.Views;
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
        public bool UpdateAddress(int addressID, string addressDetail)
        {
            try
            {
                var address = _db.AddressInformations.FirstOrDefault(x => x.ID == addressID);
                if (address != null)
                {
                    address.AddressDetail = addressDetail;
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
        public bool DeleteAddress(int addressID)
        {
            try
            {
                var address = _db.AddressInformations.FirstOrDefault(x => x.ID == addressID);
                if (address != null)
                {
                    _db.AddressInformations.Remove(address);
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
        
        public List<AddressView> GetAddressInfo()
        {
            if (_db != null)
            {
                return LoadInformations.LoadAddressInformations(_db, _key);
            }
            return null;
        }

    }
}
