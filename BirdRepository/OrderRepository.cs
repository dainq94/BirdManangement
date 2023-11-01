using BirdDAO;
using BusinessObjects.Models;

namespace BirdRepository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrders()
        => OrderDAO.Instance.GetOrders();
    }
}
