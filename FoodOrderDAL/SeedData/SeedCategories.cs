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
    public class SeedCategories : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasData
                (
                    new Categories { ID = 1, CategoryName = "Yiyecek", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new Categories { ID = 2, CategoryName = "İçecek", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
