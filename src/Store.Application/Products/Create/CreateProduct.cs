using Store.Database;
using Store.Domain.Entities;

namespace Store.Application.Products.Create
{
    public class CreateProduct
    {
        private readonly ApplicationDbContext context;

        public CreateProduct(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task Do(CreateProductModel product)
        {
            context.Products.Add(new ProductEntity
            {
                Name = product.Name,
                Description = product.Description,
            });

            return context.SaveChangesAsync();
        }
    }
}
