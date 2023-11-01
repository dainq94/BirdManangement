using BusinessObjects.Models;

namespace BirdService
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        List<Order> GetOrdersWithStatus(List<string> status);
    }
}
