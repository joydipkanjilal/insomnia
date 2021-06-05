using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsomniaRESTClient
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<bool> AddProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }
}
