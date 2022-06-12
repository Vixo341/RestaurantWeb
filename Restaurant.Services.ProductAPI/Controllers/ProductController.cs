using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Services.ProductAPI.Models;
using Restaurant.Services.ProductAPI.Models.DTO;
using Restaurant.Services.ProductAPI.Repository;

namespace Restaurant.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        protected ResponseDTO _response;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
           this._response = new ResponseDTO();

        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDTO> productDTO = await _productRepository.GetProducts();
                _response.Result = productDTO;

            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()};
            }
            return _response;
        }
    }
}
