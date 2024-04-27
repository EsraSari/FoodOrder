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
    public class AddressMapping : IEntityTypeConfiguration<AddressInformations>
    {
        public void Configure(EntityTypeBuilder<AddressInformations> builder)
        {
            builder.HasOne(x => x.City)
                .WithMany(x => x.AddressInfo)
                .HasForeignKey(x => x.CityID);

            builder.HasOne(x => x.Country)
               .WithMany(x => x.AddressInfo)
               .HasForeignKey(x => x.CountryID);

            builder.HasOne(x => x.County)
               .WithMany(x => x.AddressInfo)
               .HasForeignKey(x => x.CountyID);

            builder.HasOne(x => x.Customer)
               .WithMany(x => x.AddressInfo)
               .HasForeignKey(x => x.CustomerID);

        }
    }
}
