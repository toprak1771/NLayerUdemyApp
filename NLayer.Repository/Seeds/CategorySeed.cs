﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category() { Id = 1, Name = "Pensils", CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now},
                new Category() { Id = 2, Name = "NoteBooks", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Category() { Id = 3, Name = "Books", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
