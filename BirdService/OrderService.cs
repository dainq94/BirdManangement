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

        public void Add(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public bool Exist(int id)
        {
            return _orderRepository.Exist(id);
        }

        public Order Get(int id)
        {
            return _orderRepository.Get(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public List<Order> GetAllOrdersOfCustomer(string username)
        {
            return _orderRepository.GetAllOrdersOfCustomer(username);
        }

        public int GetAvailableProductQuantity(int id)
        {
            return _orderRepository.GetAvailableProductQuantity(id);
        }

        public List<OrderDetail> GetOrderDetails(int id)
        {
            return _orderRepository.GetOrderDetails(id);
        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public List<Order> GetOrdersWithStatus(List<string> status)
        {
            return GetOrdersWithStatus(status);
        }

        public void Save(Order entity)
        {
            _orderRepository.Save(entity);
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
            return GetOrders().Where(o => status.Contains(o.Status)).ToList();
        }
    }
}
