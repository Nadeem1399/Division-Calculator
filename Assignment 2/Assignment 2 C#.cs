using System;

namespace DivisionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the first number:");
                    double numerator = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                    double denominator = Convert.ToDouble(Console.ReadLine());

                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }

                    double result = numerator / denominator;
                    Console.WriteLine("Result: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                Console.WriteLine("Do you want to perform another division? (yes/no)");
                string continueInput = Console.ReadLine().ToLower();

                if (continueInput != "yes")
                {
                    break;
                }
            }
        }
    }
}
