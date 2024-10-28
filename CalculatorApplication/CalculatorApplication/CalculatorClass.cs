using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public class DivideByZero : Exception
    {
        public DivideByZero(string str) : base(str){}
    }
    public delegate double Formula<G>(G number1, G number2);
    internal class CalculatorClass
    {
        public static double getSum(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double getDiff(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double getProd(double number1,  double number2)
        {
            return number1 * number2;
        }
        public static double getQuot(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
