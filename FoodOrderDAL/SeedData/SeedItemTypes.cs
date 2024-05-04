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
    public class SeedItemTypes : IEntityTypeConfiguration<ItemTypes>
    {
        public void Configure(EntityTypeBuilder<ItemTypes> builder)
        {
            builder.HasData
               (
                   new ItemTypes { ID = 1, ItemName = "Ürün", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                   new ItemTypes { ID = 2, ItemName = "Menü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
               );
        }
    }
}
