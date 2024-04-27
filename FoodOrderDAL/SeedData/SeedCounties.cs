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
    public class SeedCounties : IEntityTypeConfiguration<Counties>
    {
        public void Configure(EntityTypeBuilder<Counties> builder)
        {
            builder.HasData
                 (
                     new Counties { ID = 1, CountyName = "Kağıthane", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 2, CountyName = "Şişli", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 3, CountyName = "Beşiktaş", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 4, CountyName = "Beyoğlu", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 5, CountyName = "Kadıköy", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 6, CountyName = "Üsküdar", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 7, CountyName = "Fatih", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 8, CountyName = "Bakırköy", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 9, CountyName = "Maltepe", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 10, CountyName = "Ataşehir", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 11, CountyName = "Büyükçekmece", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 12, CountyName = "Sarıyer", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 13, CountyName = "Kartal", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 14, CountyName = "Şile", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 15, CountyName = "Çatalca", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Counties { ID = 16, CountyName = "Adalar", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );  
        }
    }
}
