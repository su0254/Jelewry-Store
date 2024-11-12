
using System.Text.Json;

namespace Jelewry_Store.Entities
{
    public class DataContext : IDataContext
    {
        public static List<Branch> Branches {  get; set; } = new List<Branch>();
        public static List<Order> Orders { get; set; } = new List<Order>();
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<ProductInOrder> ProductInOrders { get; set; } = new List<ProductInOrder>();
        public static List<SortOfSending> SortOfSendings { get; set; } = new List<SortOfSending>();
        //public List<User> Users { get; set; } = new List<User>() { new User() { Id = 3, Tz = "327774881", Name = "hgj", Email = "fghj", PhoneNumber = "fghk", City = "fghj", Address = "dfg", ZipCode = "sdfgh", BirthDay = new DateTime(), EStatus = Status.WORKER }};

        public List<Branch> LoadBranches()
        {
            throw new NotImplementedException();
        }

        public List<Order> LoadOrders()
        {
            throw new NotImplementedException();
        }

        public List<Product> LoadProducts()
        {
            throw new NotImplementedException();
        }

        public List<ProductInOrder> LoadProductsInOrder()
        {
            throw new NotImplementedException();
        }

        public List<SortOfSending> LoadSortOfSending()
        {
            throw new NotImplementedException();
        }

        public List<User> LoadUsers()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "userData.json");
            string usersJson = File.ReadAllText(path);
            var allUsers=JsonSerializer.Deserialize<List<User>>(usersJson);
            return allUsers;
        }
        public bool SaveUsers(List<User> users)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "userData.json");
                string jsonUser=JsonSerializer.Serialize(users);
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonUser);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveBranches(List<Branch> branches)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrders(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        public bool SaveProducts(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public bool SaveProductsInOrders(List<ProductInOrder> productsInOrder)
        {
            throw new NotImplementedException();
        }

        public bool SaveSortOfSending(List<SortOfSending> sortOfSending)
        {
            throw new NotImplementedException();
        }

        
    }
}
