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
    public class SeedPaymentMethods : IEntityTypeConfiguration<PaymentMethods>
    {
        public void Configure(EntityTypeBuilder<PaymentMethods> builder)
        {
            builder.HasData
                (
                    new PaymentMethods {PaymentName = "Kredi/Banka Kartı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new PaymentMethods {PaymentName = "Nakit", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
