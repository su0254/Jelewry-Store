using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class OrderServices
    {
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
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public void PutOrder(int orderCode, Order order)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderCode == orderCode)
                    orders[i] = order;
            }
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
