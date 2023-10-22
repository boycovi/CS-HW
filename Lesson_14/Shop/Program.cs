namespace Shop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shop ATB = new Shop();
            Cart cart = new Cart();

            Product banana = new Product(1,"Banana", 10);
            Product apple = new Product(2,"Apple", 5);
            Product kiwi = new Product(3, "Kiwi", 15);

            ATB.AddProduct(banana);
            ATB.AddProduct(apple);
            ATB.AddProduct(kiwi);

            cart.AddToCart(banana);
            cart.AddToCart(kiwi);

            Console.WriteLine($"Items in cart:\n");
            foreach (Product product in cart.GetAllProducts())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
            }

            Console.WriteLine($"Total cart items price is:{cart.GetTotalPrice()}$\n");

            cart.RemoveFromCart(1);

            Console.WriteLine("Items in cart:");
            foreach (Product product in cart.GetAllProducts())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
            }
            Console.WriteLine($"Total cart items price is: : {cart.GetTotalPrice()}$\n");
            Console.ReadKey();
        }
    }
    
}