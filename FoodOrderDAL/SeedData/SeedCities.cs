using FoodOrderDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDAL.SeedData
{
    public class SeedCities : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.HasData
                 (
                     new Cities { ID = 1, CityName = "İstanbul", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 2, CityName = "Ankara", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 3, CityName = "İzmir", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 4, CityName = "Bursa", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 5, CityName = "Antalya", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 6, CityName = "Adana", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 7, CityName = "Konya", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 8, CityName = "Kayseri", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Cities { ID = 9, CityName = "Mersin", CountryID = 6, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
