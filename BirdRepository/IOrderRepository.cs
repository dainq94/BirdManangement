using BusinessObjects.Models;

namespace BirdRepository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
    }
}
