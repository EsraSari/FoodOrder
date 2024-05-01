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
    public class GenderMapping : IEntityTypeConfiguration<Genders>
    {
        public void Configure(EntityTypeBuilder<Genders> builder)
        {
            builder.HasMany(x => x.Customers)
                   .WithOne(x => x.Gender)
                   .HasForeignKey(x => x.GenderID);
        }
    }
}
