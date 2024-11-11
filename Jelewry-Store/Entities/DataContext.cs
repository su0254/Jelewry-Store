
namespace Jelewry_Store.Entities
{
    public class DataContext
    {
        public List<Branch> Branches { get; set; } = new List<Branch>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<ProductInOrder> ProductInOrders { get; set; } = new List<ProductInOrder>();
        public List<SortOfSending> SortOfSendings { get; set; } = new List<SortOfSending>();
        public List<User> Users { get; set; } = new List<User>() { new User() { Id = 3, Tz = "327774881", Name = "hgj", Email = "fghj", PhoneNumber = "fghk", City = "fghj", Address = "dfg", ZipCode = "sdfgh", BirthDay = new DateTime(), EStatus = Status.WORKER }};
       
    }
}
