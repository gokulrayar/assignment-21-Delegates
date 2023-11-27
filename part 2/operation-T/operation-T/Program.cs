using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operation_T
{ 

    namespace Part_2
    {
        public delegate T Operation<T>(T num1, T num2);

        public class Calculator<T>
        {
            public static T Add(T num1, T num2) => (dynamic)num1 + (dynamic)num2;

            public static T Subtract(T num1, T num2) => (dynamic)num1 - (dynamic)num2;

            public static T Multiply(T num1, T num2) => (dynamic)num1 * (dynamic)num2;

            public static T Divide(T num1, T num2)
            {
                if (EqualityComparer<T>.Default.Equals(num2, default(T)) || num2.Equals(0))
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return default(T);
                }
                else
                {
                    return (dynamic)num1 / (dynamic)num2;
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Operation<int> addDelegate = new Operation<int>(Calculator<int>.Add);
                Operation<int> subtractDelegate = new Operation<int>(Calculator<int>.Subtract);
                Operation<int> multiplyDelegate = new Operation<int>(Calculator<int>.Multiply);
                Operation<int> divideDelegate = new Operation<int>(Calculator<int>.Divide);
                Console.Write("Enter the first value: ");
                int value1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second value: ");
                int value2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = Convert.ToInt32(Console.ReadLine());
                int result = default(int);

                switch (choice)
                {
                    case 1:
                        result = addDelegate(value1, value2);
                        break;
                    case 2:
                        result = subtractDelegate(value1, value2);
                        break;
                    case 3:
                        result = multiplyDelegate(value1, value2);
                        break;
                    case 4:
                        result = divideDelegate(value1, value2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid operation.");
                        break;
                }


                Console.WriteLine($"Result: {result}");
                Console.ReadKey();
            }
        }
    }

}