namespace Jelewry_Store.Entities
{
    public enum Kategory { earrings, NECKLACE, bracelet, rings, Watches }
    public enum Target { BABIES, GIRLS, WOMENS, BRIDES }
    public class Product
    {
        public int Id { get; set; }
        public string Makat { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Qty { get; set; }
        public Kategory EKategory { get; set; }
        public Target ETarget { get; set; }

        public Product(int id, string makat, string description, double price, string color, string qty, Kategory eKategory, Target eTarget)
        {
            Id = id;
            Makat = makat;
            Description = description;
            Price = price;
            Color = color;
            Qty = qty;
            EKategory = eKategory;
            ETarget = eTarget;
        }
    }
}
