using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double n1, double n2, string opr)
        {
            double result = double.NaN;

            switch(opr)
            {
                case "add":
                    result = n1 + n2;
                    break;
                case "sub":
                    result = n1 - n2;
                    break;
                case "mul":
                    result = n1 * n2;
                    break;
                case "div":
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else Console.WriteLine("Enter a non-zero value.");
                    break;
                default:
                    Console.WriteLine("You have entered an incorrect option.");
                    break;
            }
            return result;
        }
    }
}