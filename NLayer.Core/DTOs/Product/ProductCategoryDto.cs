﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs.Product
{
    public class ProductCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
