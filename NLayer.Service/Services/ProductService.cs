using AutoMapper;
using NLayer.Core.DTOs.Product;
using NLayer.Core.Message;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Response;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork,IProductRepository productRepository,IMapper mapper) : base(repository, unitOfWork)
        {
            _mapper= mapper;
            _repository = productRepository;
        }

        public async Task<SuccessDataResult<List<ProductCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _repository.GetProductsWithCategory();
            var productCategory = _mapper.Map<List<ProductCategoryDto>>(products);
            return new SuccessDataResult<List<ProductCategoryDto>>(productCategory, Message.ReturnProduct);
        }
    }
}
