namespace Store.Domain.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public string Reference { get; set; }

        // TODO: move the below props as separate object; single-responsibility.
        public string MainAddress { get; set; }
        public string SecondaryAddress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public ICollection<ProductOrderEntity> ProductOrders { get; set; }
    }
}
