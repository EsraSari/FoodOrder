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
    public class SeedContactTypes : IEntityTypeConfiguration<ContactTypes>
    {
        public void Configure(EntityTypeBuilder<ContactTypes> builder)
        {
            builder.HasData
                 (
                     new ContactTypes { ID = 1, ContactType = "Cep Telefonu", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new ContactTypes { ID = 2, ContactType = "E-mail", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                      
                 );
        }
    }
}
