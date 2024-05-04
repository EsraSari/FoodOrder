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
    public class OrderDetailMapping : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasOne(x => x.ItemType)
              .WithMany(x => x.OrderDetails)
              .HasForeignKey(x => x.ItemTypeID);
        }
    }
}
