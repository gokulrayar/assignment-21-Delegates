using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_delegets
{
    internal class Operation
    {
        public delegate int ArithmeticOperation(int a, int b);

        public class Calculator
        {
            public static int Add(int a, int b) => a + b;
            public static int Subtract(int a, int b) => a - b;
            public static int Multiply(int a, int b) => a * b;
            public static int Divide(int a, int b) => b != 0 ? a / b : throw new ArgumentException("Cannot divide by zero");
        }
    }
}
