using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using FoodOrderDomain.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class CommunicationManager
    {
        private AppDBContext _db;
        private readonly int _key;
        public CommunicationManager()
        {
            _db = new AppDBContext();
        }

        public CommunicationManager(int key)
        {
            _db = new AppDBContext();
            _key = key;
        }
        public bool CreateComm(int contactType, string commDetail, int customerID)
        {
            try
            {
                var comm = new ContactInformations
                {
                    ContactTypeID = contactType,
                    CommDetail = commDetail,
                    CustomerID = customerID,
                    Status = true,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };
                _db.ContactInformations.Add(comm);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateComm(int commID, string commDetail)
        {
            try
            {
                var contact = _db.ContactInformations.FirstOrDefault(x => x.ID == commID);
                if (contact != null)
                {
                    contact.CommDetail = commDetail;
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

        public bool DeleteComm(int commID)
        {
            try
            {
                var contact = _db.ContactInformations.FirstOrDefault(x => x.ID == commID);
                if (contact != null)
                {
                    _db.ContactInformations.Remove(contact);
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
        public List<ContactInfoView> GetCommInfo()
        {
            if (_db != null)
            {
                return LoadInformations.LoadCommunicationInformations(_db, _key);
            }
            return null;
        }
    }
}
