namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp1.Calculator calculator = new ConsoleApp1.Calculator();

            Console.WriteLine("Welcome to the Calculator App!");

            bool performAnotherOperation = true;

            while (performAnotherOperation)
            {
                Console.WriteLine("Please enter the first number: ");
                double num1 = double.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("Please enter the operation (+, -, *, /): ");
                char operation = char.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = calculator.Calculate(num1, num2, operation);

                Console.WriteLine("The result is: " + result);

                Console.WriteLine("Do you want to perform another operation? (y/n)");
                char response = char.Parse(Console.ReadLine());

                if (response == 'n')
                {
                    performAnotherOperation = false;
                }
            }

            Console.WriteLine("Thank you for using the Calculator App!");
            Console.ReadKey();
        }
    }
}