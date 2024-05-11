using FoodOrderDAL.Context;
using FoodOrderDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class CustomerManager
    {
        private AppDBContext _db;

        public CustomerManager()
        {
            _db = new AppDBContext();
        }

        public bool RegisterCustomer(string firstName, string lastName, int gender, DateTime birthDate, string userName, string password,
            int contactType, string commDetail, int country, int city, int county, string addressDetail)
        {
            try
            {
                var customer = new Customers
                {
                    FirstName = firstName,
                    LastName = lastName,
                    GenderID = gender,
                    BirthDate = birthDate,
                    UserName = userName,
                    Password = password,
                    Status = true,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };
                _db.Customers.Add(customer);
                _db.SaveChanges();

                var contactInfo = new ContactInformations
                {
                    CustomerID = customer.ID,
                    ContactTypeID = contactType,
                    CommDetail = commDetail
                };
                _db.ContactInformations.Add(contactInfo);

                var addressInfo = new AddressInformations
                {
                    CountryID = country,
                    CityID = city,
                    CountyID = county,
                    CustomerID = customer.ID,
                    AddressDetail = addressDetail
                };
                _db.AddressInformations.Add(addressInfo);

                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    
        public int FindCustomer(string userName, string password)
        {
            if (_db.Customers.FirstOrDefault(x => x.UserName == userName && x.Password == password) != null)
            {
                int customerID = _db.Customers
                    .Where(c => c.UserName == userName && c.Password == password)
                    .Select(c => c.ID)
                    .FirstOrDefault();
                if (customerID == 0)
                {
                    return -1;
                }
                else
                {
                    return customerID;
                }
            }
            else
            {
                return -1;
            }
        }
    
    }
}
