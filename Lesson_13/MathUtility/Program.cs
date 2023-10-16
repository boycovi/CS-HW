using System.Reflection.Metadata;

namespace MathUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int add = MathUtility.Addition(5, 5);
                int sub = MathUtility.Subtraction(20, 10);
                int mult = MathUtility.Multiplication(5, 2);
                double div = MathUtility.Division(20, 2);
                Console.WriteLine($"{add}\n{sub}\n{mult}\n{div}");
            }
            catch (DivideByZeroException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
    public static class MathUtility
    {
        public static int Addition(int a, int b) { return a + b; }
        public static int Subtraction(int a, int b) { return a - b; }
        public static int Multiplication(int a, int b) { return a * b; }
        public static double Division(int a, int b)
        {
            if (a == 0)
                throw new DivideByZeroException("Division by zero");

            return (double)(a / b);
        }
    }
}