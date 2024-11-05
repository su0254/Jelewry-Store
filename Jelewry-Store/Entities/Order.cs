namespace Jelewry_Store.Entities
{
    public enum SpaicelDemand { FRAGILE, WRAP }
    public enum SortsOfSending { BYSHOP, BYHOME, EXPRESE }
    public class Order
    {
        static int id = 1;
        public int Id { get; set; }
        public int OrderCode { get; set; }
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public bool IsExsist { get; set; }
        public DateTime OrderDate { get; set; }
        public SpaicelDemand EspaicelDemand { get; set; }
        public int NumOfItemInOrder { get; set; }
        public SortsOfSending ESortOfSending { get; set; }
        //public List<Product> ProductsInOrder { get; set; }
    }
}
