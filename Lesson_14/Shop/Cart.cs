using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Cart
    {
        private List<Product> cartItems = new List<Product>();
        public void AddToCart(Product product)
        {
            cartItems.Add(product);
        }
        public void RemoveFromCart(int productId)
        {
            Product productToRemove = cartItems.Find(p => p.Id == productId);
            if (productToRemove != null)
                cartItems.Remove(productToRemove);
        }
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in cartItems)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }

        public List<Product> GetAllProducts()
        {
            return cartItems;
        }
    }
}
