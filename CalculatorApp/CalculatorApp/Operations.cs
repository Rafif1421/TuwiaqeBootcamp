using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Operations
    {
        public double Addition(double a,double b)
        {
            double RESULT=a+b;
            return RESULT;
        }
        public double Subtraction(double a, double b)
        {
            double RESULT = a - b;
            return RESULT;
        }
        public double Multiplication(double a, double b)
        {
            double RESULT = a * b;
            return RESULT;
        }
        public double Dividing(double a, double b)
        {
            double RESULT = a / b;
            return RESULT;
        }
    }
}
