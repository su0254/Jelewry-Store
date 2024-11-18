using Jelewry_Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Jelewry_Store.Data
{
    internal class DataContext
    {
        public List<User> users { get; set; }
        public List<Branch> branches { get; set; }
        public List<Order> orders { get; set; }
        public List<Product> products { get; set; }
        public List<SortOfSending> sortOfSendings { get; set; }
        public DataContext()
        {
            //load from file
        }

        public bool SaveUsers()
        {
            //write to file
            return true;
        }
        public bool SaveProducts()
        {
            //write to file
            return true;
        }
        public bool SaveOrders()
        {
            //write to file
            return true;
        }
        public bool SaveBranches()
        {
            //write to file
            return true;
        }
        public bool SaveSortOfSendings()
        {
            //write to file
            return true;
        }
    }
}
