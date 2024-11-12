using Jelewry_Store.Entities;

namespace Jelewry_Store
{
    public interface IDataContext
    {
        //Users
        public List<User> LoadUsers();
        public bool SaveUsers(List<User> users);
        //Orders
        public List<Order> LoadOrders();
        public bool SaveOrders(List<Order> orders);
        //Products
        public List<Product> LoadProducts();
        public bool SaveProducts(List<Product> products);
        //Sort of sending
        public List<SortOfSending> LoadSortOfSending();
        public bool SaveSortOfSending(List<SortOfSending> sortOfSending);
        //Branches
        public List<Branch> LoadBranches();
        public bool SaveBranches(List<Branch> branches);
        //Products in orders
        public List<ProductInOrder> LoadProductsInOrder();
        public bool SaveProductsInOrders(List<ProductInOrder> productsInOrder);
    }
}
