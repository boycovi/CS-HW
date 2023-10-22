using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Shop
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            Product productToRemove = products.Find(p => p.Id == productId);
            if (productToRemove != null)
                products.Remove(productToRemove);
        }
        public Product GetProductById(int productId)
        {
            return products.Find(p=>p.Id==productId);
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
