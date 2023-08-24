using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Division
    {
        public void Divide()
        {
            Console.WriteLine("Enter Dividend");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisior");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        }
    }
}
