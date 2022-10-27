using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //Assembly sayesinde bütün configurationsları bulup yapar.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Ayrı config sınıfları yerine buradan da aşağıdaki syntax ile yazılabilir.
            //modelBuilder.Entity<Category>().Property(p => p.Name).IsRequired();
            //modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);

            //Tek tek configurationları uygulamak istersen
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<ProductFeature>().HasData
            (
                new ProductFeature()
                {
                    Id = 1,
                    Color = "Black",
                    Height = 100,
                    Width = 200,
                    ProductId = 1
                },
                new ProductFeature()
                {
                    Id = 2,
                    Color = "Red",
                    Height = 300,
                    Width = 500,
                    ProductId = 2
                }
            );
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
