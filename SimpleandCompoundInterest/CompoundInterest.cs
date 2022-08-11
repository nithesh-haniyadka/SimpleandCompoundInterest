using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleIntrest
{
    internal class CompoundInterest
    {
        public double intrest(int princip, int Time, int rate)
        {

            Imath imath = new Math();
            double denominator = 100;
            double divide = imath.division(rate, denominator);
            double add = 1;
            double addsum = imath.add(add, divide);
            double ci = 1;
            for (int i = 1; i <= Time; i++)
            {
                ci = imath.mulitply(ci, addsum);

            }
            double intrest = imath.mulitply(ci, princip);


            return intrest;




        }

    }
}
