using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
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
            var productDto = _mapper.Map<ProductDto>(product);
            return new SuccessDataResult<ProductDto>(productDto, Message.ReturnProduct);           
        }

        [HttpPost]
        public async Task<IDataResult<ProductDto>> Create(ProductDto newProduct)
        {
            var product = await _services.GetByIdAsync(newProduct.Id);
            if(product is not null) { return new ErrorDataResult<ProductDto>("Hatalı"); };

            product = await _services.AddAsync(_mapper.Map<Product>(newProduct));
            var addedProduct = _mapper.Map<ProductDto>(product);
            return new SuccessDataResult<ProductDto>(addedProduct,Message.ReturnProduct);
        }
        //deneme
    }
}
