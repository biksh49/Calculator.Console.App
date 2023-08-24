using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Substraction
    {
        public void Subs()
        {
            Console.WriteLine("Enter two numbers you want to Substract");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }

        public void ArrayDiff()
        {
            int diff;
            Sorting sorting = new Sorting(); 
            Console.Write("How many numbers do you want to find the difference of:");
            int number = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[number];
            int[] sortedArray = new int[number];
            Console.WriteLine("Enter your Numbers:");

            for (int i = 0; i < number; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine());
            }

            sortedArray = sorting.BubbleSortDesc(arrayNum, number);

            diff = sortedArray[0];

            for (int i = 1; i < number; i++)
            {
                diff = diff - sortedArray[i];
            }
            Console.WriteLine($"Difference of given numbers is: {diff}");
        }

    }
}
