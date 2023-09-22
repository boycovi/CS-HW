namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double oper1, oper2, result;
            Operation operation;

            Console.Write("Enter first operand: ");
            oper1 = GetDoubleNumber();
            Console.Write("Enter second operand: ");
            oper2 = GetDoubleNumber();
            Console.Write("Enter operation (+, -, *, /): ");
            operation = GetOperation();

            result = DoOperation(oper1, oper2, operation);

            Console.WriteLine("{0} {1} {2} = {3}", oper1, operation, oper2, result);
        }

        static Operation GetOperation()
        {
            Operation operation;
            while (true)
            {
                string input = Console.ReadLine();

                if (Enum.TryParse(input, out operation) && Enum.IsDefined(typeof(Operation), operation))
                {
                    if (operation == Operation.None)
                        Console.Write("Wrong Input (1:+, 2:-, 3:*, 4:/): ");
                    else
                        return operation;
                }
                else
                {
                    Console.Write("Wrong Input (1:+, 2:-, 3:*, 4:/): ");
                }
            }
        }

        static double GetDoubleNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Wrong Input: ");
            }
            return number;
        }

        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            double result;
            switch (operation)
            {
                case Operation.Add:
                    result = oper1 + oper2;
                    break;
                case Operation.Subtract:
                    result = oper1 - oper2;
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2;
                    break;
                case Operation.Divide:
                    if (oper2 == 0)
                    {
                        Console.WriteLine("Cant divide by zero");
                        Environment.Exit(1);
                    }
                    result = oper1 / oper2;
                    break;
                default:
                    throw new ArgumentException("Incorrect operation");
            }
            return result;
        }
    }

    enum Operation
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide
    }
}