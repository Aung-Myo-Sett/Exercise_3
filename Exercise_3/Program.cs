using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid input for the first number.");
                    return;
                }

                Console.Write("Enter an operator (+, -, *, /, %): ");
                string sign = Console.ReadLine();

                Console.Write("Enter another number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input for the second number.");
                    return;
                }

                double result = 0;
                bool validOperation = true;

                switch (sign)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            validOperation = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    case "%":
                        result = num1 % num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"The result is {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
