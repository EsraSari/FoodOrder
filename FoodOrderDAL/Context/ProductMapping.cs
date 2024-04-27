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
    public class ProductMapping : IEntityTypeConfiguration<Products>
    {   
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(x => x.ProductName).IsRequired();


            builder.HasOne(x => x.ProductDetail)
                .WithOne(x => x.Product)
                .HasForeignKey<ProductDetails>(x => x.ProductID);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Product)
                .HasForeignKey(x => x.CategoryID);

            builder.HasOne(x => x.Stock)
                .WithOne(x => x.Product)
                .HasForeignKey<Stock>(x => x.ProductID);


        }
    }
}
