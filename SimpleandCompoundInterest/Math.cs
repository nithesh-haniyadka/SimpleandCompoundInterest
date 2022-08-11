using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleIntrest
{
    public class Math : Imath
    {
        int x, y, z;
        double d;
        public double add(double a, double b)
        {

            double h = a + b;
            return h;
        }

        public void subtract(int a, int b)
        {

            y = a - b;
        }

        public double mulitply(int a, int b, int c)
        {
            double mul = a * b * c;
            return mul;

        }

        public double division(double a, double b)
        {

            d = a / b;
            return d;
        }

        public void display()
        {
            Console.WriteLine("Sum : " + x);
            Console.WriteLine("Substract : " + y);
            Console.WriteLine("Multiply :" + z);
            Console.WriteLine("Division :" + d);


        }

        public double mulitply(double a, double b)
        {
            double d;
            d = a * b;
            return d;
        }
    }
}
