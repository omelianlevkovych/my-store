namespace Store.Domain.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<StockEntity> Stocks { get; set; }
        public ICollection<ProductOrderEntity> ProductOrders { get; set; }
    }
}
