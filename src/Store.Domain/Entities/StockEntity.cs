namespace Store.Domain.Entities
{
    public class StockEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
