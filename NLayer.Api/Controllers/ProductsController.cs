using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.Product;
using NLayer.Core.Message;
using NLayer.Core.Models;
using NLayer.Core.Response;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _services;

        public ProductsController(IMapper mapper, IService<Product> services)
        {
            _mapper = mapper;
            _services = services;
        }
        [HttpGet]
        public async Task<IDataResult<List<ProductDto>>> All()
        {
            var products = await _services.GetAllAsync();
            List<ProductDto> productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return new SuccessDataResult<List<ProductDto>>(productsDtos, Message.ReturnProduct);
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<ProductDto>> GetById(int id)
        {
            var product = await _services.GetByIdAsync(id);
            if (product == null) return new ErrorDataResult<ProductDto>(Message.ErrorReturnProduct);
            var productDto = _mapper.Map<ProductDto>(product);
            return new SuccessDataResult<ProductDto>(productDto, Message.ReturnProduct);
        }

        [HttpPost]
        public async Task<IDataResult<CreateProductDto>> Create(CreateProductDto newProduct)
        {
            var productControl = await _services.AnyAsync(x=>x.Name==newProduct.Name);
            if (productControl) { return new ErrorDataResult<CreateProductDto>(Message.ErrorCreateProduct); };

            var product = await _services.AddAsync(_mapper.Map<Product>(newProduct));
            var addedProduct = _mapper.Map<CreateProductDto>(product);
            return new SuccessDataResult<CreateProductDto>(addedProduct, Message.SuccessCreateProduct);
        }

        [HttpDelete("{id}")]
        public async Task<Core.Response.IResult> Delete(int id)
        {
            var product = await _services.GetByIdAsync(id);
            if (product is null)
            {
                return new ErrorResult(Message.ErrorDeleteProduct);
            }
            
                await _services.RemoveAsync(product);
                return new SuccessResult(Message.SuccessDeleteProduct);            
        }

        [HttpPut("{id}")]
        public async Task<Core.Response.IResult> Update(int id,UpdatedProductDto updatedProduct)
        {
            var product = await _services.GetByIdAsync(id);
            if(product is null)
            {
                return new ErrorResult(Message.ErrorUpdateProduct);
            }
                product = _mapper.Map<Product>(updatedProduct);
                await _services.UpdateAsync(product);
                return new SuccessResult(Message.SuccessUpdateProduct);          
        }

        //deneme
    }
}
