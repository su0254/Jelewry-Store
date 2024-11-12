using Jelewry_Store;
using Jelewry_Store.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJelewry_Store
{
    internal class FakeContext : IDataContext
    {
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
            User user = new User();
            user.Id = 1;
            user.Address = "fgjhk";
            user.EStatus=Status.WORKER;
            user.Email = "sdfghjk";
            user.City = "sdfghj";
            user.BirthDay = DateTime.Now;
            user.PhoneNumber = "234567";
            user.Tz = "327774881";
            user.ZipCode = "653";
            return new List<User> { user };
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

        public bool SaveUsers(List<User> users)
        {
            return true;
        }
    }
}
