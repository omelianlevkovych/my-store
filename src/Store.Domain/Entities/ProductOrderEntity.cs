﻿namespace Store.Domain.Entities
{
    public class ProductOrderEntity
    {
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
