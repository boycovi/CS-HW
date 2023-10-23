namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Filtering
            List<int> intList = new List<int> { 2, 5, 8, 12, 15, 18, 22 };
            intList = intList.Where(p => p > 10).ToList();
            foreach (int i in intList)
            {
                Console.Write(i + " \n");
            }

            //2.Sorting
            List<string> fruitsList = new List<string> { "Orange", "Kiwi", "Apple", "Banana" };
            fruitsList.Sort();
            Console.WriteLine("");
            foreach (string i in fruitsList)
            {
                Console.Write(i + " \n");
            }

            //3.Delete duplicates
            List<string> charList = new List<string> { "a", "b", "c", "a", "d", "c" };
            var uniqueStrings = charList.Distinct();
            Console.WriteLine();
            foreach (var i in uniqueStrings)
            {
                Console.WriteLine(i);
            }

            //4.Count
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 90 };
            Console.WriteLine();
            Console.WriteLine(grades.Count(p=>p>90));

            //5.Filtering+Sorting
            List<Product> products = new List<Product>
        {
            new Product { Name = "Prod1", Price = 45 },
            new Product { Name = "Prod2", Price = 60 },
            new Product { Name = "Prod3", Price = 30 },
            new Product { Name = "Prod4", Price = 55 },
        };
            var prodFiltered = products.Where(products => products.Price < 50).OrderBy(products=>products.Price).ToList();
            Console.WriteLine();
            foreach (var i in prodFiltered)
            {
                Console.WriteLine($"{i.Name}:{i.Price}$");
            }

            //6.Find max by index
            List<int> nums = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
            Console.WriteLine(nums.IndexOf(nums.Max()));
            Console.ReadKey();
        }
    }
}