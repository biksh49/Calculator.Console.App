using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sorting
    {
        public int[] BubbleSortDesc(int[] arrayNum, int number)
        {
            int temp;

            for (int i = 0; i < number; i++)
            {
                for (int j = i; j < number; j++)
                {
                    if (arrayNum[j] > arrayNum[i])
                    {
                        temp = arrayNum[j];
                        arrayNum[j] = arrayNum[i];
                        arrayNum[i] = temp;
                    }
                }
            }
            return arrayNum;
        }
    }
}
