using Restaurant.Web.Models;

namespace Restaurant.Web.Services.IServices
{
    interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetAllProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDTO);
        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);

        Task<T> DeleteProductAsync<T>(int id);

    }
}
