using BirdRepository;
using BusinessObjects.Models;

namespace BirdService
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService()
        {
            _cartRepository = new CartRepository();
        }
        public void DeleteCartById(int id)
        {
            _cartRepository.DeleteCartById(id);
        }

        public List<Cart> GetAllCartItemsByUsername(string username)
        {
            return _cartRepository.GetAllCartItemsByUsername(username);
        }

        public Cart GetCartById(string username, int cartId)
        {
            return _cartRepository.GetCartById(username, cartId);
        }

        public bool RefreshAllCart(string username)
        {
            return _cartRepository.RefreshAllCart(username);
        }

        public void RefreshCart(int id)
        {
            _cartRepository.RefreshCart(id);
        }

        public void Save(Cart cart)
        {
            _cartRepository.Save(cart);
        }

        public void UpdateCartQuantityById(int id, int quantity)
        {
            _cartRepository.UpdateCartQuantityById(id, quantity);
        }
    }
}
