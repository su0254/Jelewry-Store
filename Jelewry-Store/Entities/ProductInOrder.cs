namespace Jelewry_Store.Entities
{
    public class ProductInOrder
    {
        public int CodeProductOrder { get; set; }
        public Product CodeProduct { get; set; }
        public Order CodeOrder { get; set;}
        public int InvoiceProduct { get; set;}
    }
}
