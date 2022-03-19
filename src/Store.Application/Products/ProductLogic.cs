using Microsoft.EntityFrameworkCore;
using Store.Application.Products.Interfaces;
using Store.Application.Products.Models;
using Store.Database;
using Store.Domain.Entities;

namespace Store.Application.Products
{
    public class ProductLogic : IProductLogic
    {
        private readonly ApplicationDbContext context;

        public ProductLogic(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task CreateProduct(ProductModel product)
        {
            context.Products.Add(new ProductEntity
            {
                Name = product.Name,
                Description = product.Description,
            });

            return context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            return await context.Products.Select(x => new ProductModel
           {
               Name = x.Name,
               Description = x.Description,
           }).ToListAsync();
        }
    }
}
