using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.UnitTest.MathOperations
{
    public class Operations
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            // kasıtlı yanlış yazıldı, test sırasında hata verecek!
            return num1 + num2;
        }

        public bool IsItPositive(int num)
        {
            if (num >= 0)
                return true;
            else
                return false;
        }
    }
}
