using FoodOrderDAL.SeedData;
using FoodOrderDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDAL.Context
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LENOVO; Initial Catalog = FoodOrders; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
            .HasIndex(x => x.UserName) // Benzersiz olmasını istediğiniz özelliği belirtin
            .IsUnique();

            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new ContactInfoMapping());
            modelBuilder.ApplyConfiguration(new MenuMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new GenderMapping());

            modelBuilder.ApplyConfiguration(new SeedOrderState());
            modelBuilder.ApplyConfiguration(new SeedPaymentMethods());
            modelBuilder.ApplyConfiguration(new SeedCities());
            modelBuilder.ApplyConfiguration(new SeedCounties());
            modelBuilder.ApplyConfiguration(new SeedCountries());
            modelBuilder.ApplyConfiguration(new SeedGenders());
            modelBuilder.ApplyConfiguration(new SeedCategories());
            modelBuilder.ApplyConfiguration(new SeedProducts());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AddressInformations> AddressInformations { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities{ get; set; }
        public DbSet<Countries> Countries{ get; set; }
        public DbSet<Counties> Counties{ get; set; }
        public DbSet<ContactInformations> ContactInformations{ get; set; }
        public DbSet<ContactTypes> ContactTypes{ get; set; }
        public DbSet<Customers> Customers{ get; set; }
        public DbSet<Products> Products{ get; set; }
        public DbSet<Menu> Menu{ get; set; }
        public DbSet<PaymentMethods> PaymentMethods{ get; set; }
        public DbSet<Stock> Stocks{ get; set; }
        public DbSet<ProductDetails> ProductDetails{ get; set; }
        public DbSet<ProductMenu> ProductMenu{ get; set; }
        public DbSet<OrderDetails> OrderDetails{ get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStates> OrderStates{ get; set; }

        public DbSet<Genders> Genders{ get; set; }


    }
}
