


namespace ConsoleApp1;

    
    public class Calculator
    {
        public double Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return Add(num1, num2);
                case '-':
                    return Subtract(num1, num2);
                case '*':
                    return Multiply(num1, num2);
                case '/':
                    return Divide(num1, num2);
                default:
                    throw new ArgumentException("Invalid operation selected");
            }
        }

        private double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return num1 / num2;
        }
    }

