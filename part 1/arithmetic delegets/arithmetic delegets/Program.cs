using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static arithmetic_delegets.Operation;

namespace arithmetic_delegets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ArithmeticOperation addDelegate = Calculator.Add;
                ArithmeticOperation subtractDelegate = Calculator.Subtract;
                ArithmeticOperation multiplyDelegate = Calculator.Multiply;
                ArithmeticOperation divideDelegate = Calculator.Divide;

                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = addDelegate(num1, num2);
                        break;
                    case 2:
                        result = subtractDelegate(num1, num2);
                        break;
                    case 3:
                        result = multiplyDelegate(num1, num2);
                        break;
                    case 4:
                        try
                        {
                            result = divideDelegate(num1, num2);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid ");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
        }
           
    }
    
}
