using NLayer.Core.DTOs.Product;
using NLayer.Core.Models;
using NLayer.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<SuccessDataResult<List<ProductCategoryDto>>> GetProductsWithCategory();   
    }
}
