using BusinessObjects.Models;

namespace BirdDAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        public OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        public List<Order> GetOrders()
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }      
    }
}
