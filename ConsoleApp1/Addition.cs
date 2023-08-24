using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Addition
    {
        public void Add()
        {
            Console.WriteLine("Enter two numbers you want to add");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }

        public int ArraySum(int number)
        {
            int sum = 0;
            int[] arrayNum = new int[number];

            Console.WriteLine("Enter your Numbers:");

            for (int i = 0; i < number; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                sum = sum + arrayNum[i];
            }
            return sum;
        }

        public void Average()
        {
            Console.Write("How many numbers do you want to find the average of:");
            int number = int.Parse(Console.ReadLine());
            int sum = ArraySum(number);
            Console.WriteLine($"Average of given numbers is: {sum / number}");
        }
    }
}
