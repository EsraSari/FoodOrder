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
    public class SeedCountries : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.HasData
                 (
                     new Countries { ID = 1, CountryName = "Türkiye", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 2, CountryName = "Almanya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 3, CountryName = "Fransa", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 4, CountryName = "İngiltere", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 5, CountryName = "İtalya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 6, CountryName = "İspanya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 7, CountryName = "Türkiye", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 8, CountryName = "Ukrayna", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 9, CountryName = "Polonya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 10, CountryName = "Romanya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Countries { ID = 11, CountryName = "Hollanda", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
