using Store.Application.Products.Models;

namespace Store.Application.Products.Interfaces
{
    public interface IProductLogic
    {
        Task CreateProduct(ProductModel product);
        Task<IEnumerable<ProductModel>> GetProducts();
    }
}
