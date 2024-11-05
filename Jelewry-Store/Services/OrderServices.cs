using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class OrderServices
    {
        static int id = 1;
        static List<Order> orders = new List<Order>();

        public List<Order> GetAllOrders()
        {
            return orders;
        }
        public Order GetOrderById(int orderCode)
        {
            foreach (var order in orders)
            {
                if(order.OrderCode == orderCode)
                    return order;
            }
            return null;
        }
        public bool AddOrder(Order order)
        {
            if (order == null) return false;
            order.Id = id++;
            orders.Add(order);
            return true;
        }
        public bool PutOrder(int orderCode, Order order)
        {
            if (order == null) return false;
           Order o=orders.Find(o=>o.OrderCode == orderCode);
            o.UserId = order.UserId;
            o.OrderDate = order.OrderDate;
            o.IsExsist = order.IsExsist;
            o.TotalPrice = order.TotalPrice;
            o.EspaicelDemand = order.EspaicelDemand;
            o.ESortOfSending = order.ESortOfSending;
            o.NumOfItemInOrder = order.NumOfItemInOrder;
            return true;
            
        }
        public void DeleteOrder(int orderCode)
        {
            foreach(var order in orders)
            {
                if (order.OrderCode == orderCode)
                {
                    orders.Remove(order);
                    return;
                }
            }
        }
    }
}
