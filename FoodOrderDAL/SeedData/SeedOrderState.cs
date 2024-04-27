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
    public class SeedOrderState : IEntityTypeConfiguration<OrderStates>
    {
        public void Configure(EntityTypeBuilder<OrderStates> builder)
        {
            builder.HasData
                 (
                     new OrderStates { ID = 1, OrderState = "Hazırlanıyor", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now},
                     new OrderStates { ID = 2, OrderState = "Teslim Edildi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new OrderStates { ID = 3, OrderState = "İptal Edildi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
