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
    public class OrderMapping : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasOne(x => x.Address)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.AddressID);

            builder.HasOne(x => x.ContactInfo)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.ContactID);

            builder.HasOne(x => x.Customer)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.CustomerID);

            builder.HasOne(x => x.OrderState)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.OrderStateID);

            builder.HasOne(x => x.PaymentMethod)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.PaymentMethodID);

            builder.HasOne(x => x.Customer)
               .WithMany(x => x.Orders)
               .HasForeignKey(x => x.CustomerID);

            builder.HasMany(x => x.OrderDetails)
               .WithOne(x => x.Order)
               .HasForeignKey(x => x.OrderID);

        }
    }
}
