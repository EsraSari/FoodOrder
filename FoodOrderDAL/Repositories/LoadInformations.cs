using FoodOrderDAL.Context;
using FoodOrderDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDAL.Repositories
{
    public class LoadInformations
    {

        public static List<AddressInformations> LoadAddressInformations(AppDBContext db, int cid)
        {
            var addressInformations = (from ad in db.AddressInformations
                                       where ad.CustomerID == cid
                                       select new AddressInformations
                                       {
                                           ID = ad.ID,
                                           CustomerID = ad.CustomerID,
                                           AddressDetail = ad.AddressDetail
                                       }).ToList();

            return addressInformations;
        }
    }
}
