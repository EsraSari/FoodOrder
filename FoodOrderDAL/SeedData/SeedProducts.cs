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
    public class SeedProducts : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData
                  (
                      new Products { ID = 1, ProductName = "Patates", CategoryID = 1, Price = 15, PreparationTime = 5, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                      new Products { ID = 2, ProductName = "Kola", CategoryID = 2, Price = 10, PreparationTime = 0, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                      new Products { ID = 3, ProductName = "Ketçap", CategoryID = 1, Price = 0, PreparationTime = 0, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                      new Products { ID = 4, ProductName = "Mayonez", CategoryID = 1, Price = 0, PreparationTime = 0, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                  );
        }
    }
}
