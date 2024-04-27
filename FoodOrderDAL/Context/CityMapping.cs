using FoodOrderDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDAL.Context
{
    public class CityMapping : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.HasOne(x => x.Country)
               .WithMany(x => x.City)
               .HasForeignKey(x => x.CountryID);


            builder.HasMany(x => x.County)
               .WithOne(x => x.City)
               .HasForeignKey(x => x.CityID);
        }
    }
}
