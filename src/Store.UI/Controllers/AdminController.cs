using Microsoft.AspNetCore.Mvc;
using Store.Application.Products.Interfaces;
using Store.Application.Products.Models;

namespace Store.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IProductLogic productLogic;

        public AdminController(IProductLogic productLogic)
        {
            this.productLogic = productLogic;
        }

        [HttpGet]
        public  Task<IEnumerable<ProductModel>> GetProducts()
        {
            return productLogic.GetProducts();
        }

        [HttpGet("{id}")]
        public Task<ProductModel> GetProduct(int productId)
        {
            return productLogic.GetProduct(productId);
        }

        [HttpPost]
        public Task CreateProduct(ProductModel productModel)
        {
            return productLogic.CreateProduct(productModel);
        }

        [HttpDelete]
        public Task DeleteProduct(int productId)
        {
            return productLogic.DeleteProduct(productId);
        }

        [HttpPut]
        public Task UpdateProduct(ProductModel productModel)
        { 
            return productLogic.UpdateProduct(productModel);    
        }

    }
}
