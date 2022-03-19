using Microsoft.EntityFrameworkCore;
using Store.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Products.Get
{
    public class GetProducts
    {
        private readonly ApplicationDbContext context;

        public GetProducts(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<GetProductModel>> Do()
        {
           return await context.Products.Select(x => new GetProductModel
           {
               Name = x.Name,
               Description = x.Description,
           }).ToListAsync();
        }
    }
}
