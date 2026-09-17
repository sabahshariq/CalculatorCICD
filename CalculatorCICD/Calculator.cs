using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorCICD
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a - b; //For testing intentionally changed
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }
    }
}
