using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ToThePower
    {
        public int PowerCalculation(int number, int Power)
        {
            int result = 1;
            for (int i = 0; i < Power; i++)
            {
                result = result * number;
            }

            return result;
        }

        public double PowerCalculation(int number, double power) 
        {
            if (power == 0.5)
            {
                return Math.Sqrt(number);
            } else if (power == 0.3)
            {
                return Math.Cbrt(number);
            } else
            {
                return 0;
            }
        }
    }
}
