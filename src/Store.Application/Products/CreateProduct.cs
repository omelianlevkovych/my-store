﻿using Store.Database;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Products
{
    public class CreateProduct
    {
        private readonly ApplicationDbContext context;

        public CreateProduct(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task Do(string name, string description)
        {
            context.Products.Add(new ProductEntity
            {
                Name = name,
                Description = description,
            });

            return context.SaveChangesAsync();
        }
    }
}
