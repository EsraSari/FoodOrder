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
    public class SeedGenders : IEntityTypeConfiguration<Genders>
    {
        public void Configure(EntityTypeBuilder<Genders> builder)
        {
            builder.HasData
                 (
                     new Genders { ID = 1, Gender = "Kadın", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Genders { ID = 2, Gender = "Erkek", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 ); 
        }
    }
}
