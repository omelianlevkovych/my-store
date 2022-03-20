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

        public async Task DeleteProduct(int productId)
        {
            // TODO: add soft-delete here
            var product = await context.Products.FindAsync(productId);
            // mb check for null here
            context.Products.Remove(product);
            await context.SaveChangesAsync();
        }

        public async Task<ProductModel> GetProduct(int productId)
        {
            var product = await context.Products.FindAsync(productId);
            if (product is null)
            {
                // log message or throw an exception
                return null;
            }
            // TODO: add some extension method for mapping; or use some lib
            return new GetProductModel
            {
                Id = product.Id,
                Name = product.Name,
                Description= product.Description,
            };
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            return await context.Products.Select(x => new ProductModel
           {
               Name = x.Name,
               Description = x.Description,
           }).ToListAsync();
        }

        public Task UpdateProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
