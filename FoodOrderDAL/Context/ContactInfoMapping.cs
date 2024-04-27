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
    public class ContactInfoMapping : IEntityTypeConfiguration<ContactInformations>
    {
        public void Configure(EntityTypeBuilder<ContactInformations> builder)
        {
            builder.HasOne(x => x.Customer)
               .WithMany(x => x.ContactInfo)
               .HasForeignKey(x => x.CustomerID);

            builder.HasOne(x => x.ContactType)
               .WithMany(x => x.ContactInfo)
               .HasForeignKey(x => x.ContactTypeID);
        }
    }
}
