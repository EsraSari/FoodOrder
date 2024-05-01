using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderBL
{
    public class LoadInformationManager
    {
        private readonly AppDBContext _db;
        private readonly int _key;
        public LoadInformationManager(AppDBContext db, int key)
        {
            _db = db;
            _key = key;
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
