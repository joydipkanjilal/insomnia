using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsomniaRESTClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return await _productRepository.GetProducts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return await _productRepository.GetProduct(id);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Product product)
        {
            return await _productRepository.AddProduct(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _productRepository.DeleteProduct(id);
        }
    }
}
