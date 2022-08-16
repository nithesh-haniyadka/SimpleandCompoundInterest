using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleIntrest
{

    internal class SimpleInterest : Math, ICalculator
    {

        public double intrest(int princip, int Time, int rate)
        {

            Imath imath = new Math(); //Calling an interface
            double multi = imath.mulitply(princip, Time, rate);
            double denominator = 100;
            double intrest = imath.division(Convert.ToInt32(multi), denominator);
            return intrest;


        }


    }
}
