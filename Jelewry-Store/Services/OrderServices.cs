using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class OrderServices
    {
        
        static int id = 1;
        
        public List<Order> GetAllOrders()
        {
            return DataContext.Orders;
        }
        public Order GetOrderById(int orderCode)
        {
            if (DataContext.Orders == null) return null;
            return DataContext.Orders.Find((o) => o.OrderCode == orderCode);
        }
        public bool AddOrder(Order order)
        {
            if (order == null) return false;
            order.Id = id++;
            DataContext.Orders.Add(order);
            return true;
        }
        public bool PutOrder(int orderCode, Order order)
        {
            if (order == null) return false;
           Order o= DataContext.Orders.Find(o=>o.OrderCode == orderCode);
            o.UserId = order.UserId;
            o.OrderDate = order.OrderDate;
            o.IsExsist = order.IsExsist;
            o.TotalPrice = order.TotalPrice;
            o.EspaicelDemand = order.EspaicelDemand;
            o.ESortOfSending = order.ESortOfSending;
            o.NumOfItemInOrder = order.NumOfItemInOrder;
            return true;
            
        }
        public bool DeleteOrder(int orderCode)
        {
            Order o = DataContext.Orders.Find((o) => o.OrderCode == orderCode);
            if (o == null) return false;
            DataContext.Orders.Remove(o);
            return true;
        }
    }
}
