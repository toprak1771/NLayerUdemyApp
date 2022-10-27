using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product() 
                {
                    Id= 1,  
                    Name="Faber Castell Grip",
                    CreatedDate= DateTime.Now,
                    CategoryId=1,
                    Price=66,
                    Stock=50,                    
                },
                 new Product()
                 {
                     Id = 2,
                     Name = "Faber Castell Grip Plus",
                     CreatedDate = DateTime.Now,
                     CategoryId = 1,
                     Price = 120,
                     Stock = 60,
                 },
                  new Product()
                  {
                      Id = 3,
                      Name = "Notebook 1",
                      CreatedDate = DateTime.Now,
                      CategoryId = 2,
                      Price = 50,
                      Stock = 40,
                  },
                   new Product()
                   {
                       Id = 4,
                       Name = "Notebook 2",
                       CreatedDate = DateTime.Now,
                       CategoryId = 2,
                       Price = 70,
                       Stock = 30,
                   }
            );
        }
    }
}
