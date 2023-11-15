using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace BirdDAO
{
    public class CartDAO
    {
        private static CartDAO instance;
        public CartDAO() { }
        public static CartDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartDAO();
                }
                return instance;
            }
        }
        public List<Cart> GetAllCartItems()
        {
            try
            {
                using (var context = new BirdContext())
                {
                    return context.Carts.Include(c => c.Product).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Save(Cart cart)
        {
            try
            {
                using (var context = new BirdContext())
                {

                    Cart c = context.Carts.SingleOrDefault(o => o.Username == cart.Username && o.ProductId == cart.ProductId) as Cart;

                    if (c != null)
                    {
                        c.LastUpDatedTime = DateTime.Now;
                        c.Quantity++;
                    }
                    else
                    {
                        cart.LastUpDatedTime = DateTime.Now;
                        context.Carts.Add(cart);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateCartQuantityById(int id, int quantity)
        {
            try
            {
                using (var context = new BirdContext())
                {
                    Cart cart = context.Carts.Find(id);
                    cart.LastUpDatedTime = DateTime.Now;
                    cart.Quantity = quantity;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCartById(int id)
        {
            try
            {
                using (var context = new BirdContext())
                {
                    Cart cart = context.Carts.SingleOrDefault(c => c.Id == id);
                    context.Carts.Remove(cart);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
