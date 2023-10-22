namespace Queue
{
    class Program
    {
        static Queue<Order> orderQueue = new Queue<Order>();
        static int processedOrders = 0;
        static double totalProcessedCost = 0.0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect Action:");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Process Order");
                Console.WriteLine("3. Display Order Queue");
                Console.WriteLine("4. Displya Statistics");
                Console.WriteLine("5. Exit\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddOrder();
                        break;
                    case "2":
                        ProcessOrder();
                        break;
                    case "3":
                        DisplayOrderQueue();
                        break;
                    case "4":
                        DisplayStatistics();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }
            }
        }
        static void AddOrder()
        {
            Console.WriteLine("Enter order№:");
            int orderNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter client's name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter total order cost:");
            double totalCost = double.Parse(Console.ReadLine());

            Order order = new Order
            {
                OrderNumber = orderNumber,
                CustomerName = customerName,
                TotalCost = totalCost
            };

            orderQueue.Enqueue(order);
            Console.WriteLine("Order added to the queue.");
        }
        static void ProcessOrder()
        {
            if (orderQueue.Count > 0)
            {
                Order order = orderQueue.Dequeue();
                processedOrders++;
                totalProcessedCost += order.TotalCost;
                Console.WriteLine($"Order №{order.OrderNumber} processed.");
            }
            else
            {
                Console.WriteLine("Order queue is empty.");
            }
        }
        static void DisplayOrderQueue()
        {
            Console.WriteLine("Order in queue:");
            foreach (Order order in orderQueue)
            {
                Console.WriteLine($"№{order.OrderNumber}, Customer: {order.CustomerName}, Cost: {order.TotalCost:C}");
            }
        }
        static void DisplayStatistics()
        {
            Console.WriteLine($"Total processed orders: {processedOrders}");
            Console.WriteLine($"Total sum of processed orders: {totalProcessedCost:C}");
        }
    }
}