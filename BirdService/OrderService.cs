using BirdRepository;
using BusinessObjects.Models;

namespace BirdService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public List<Order> GetOrdersWithStatus(List<string> status)
        {
            return GetOrders().Where(o => status.Contains(o.Status)).ToList();
        }
    }
}
