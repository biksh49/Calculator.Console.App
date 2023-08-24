using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Multiplication
    {
        public void Multiply()
        {
            Console.WriteLine("Enter two numbers you want to Multiply");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }

        public void MultiplicationTable()
        {
            Console.WriteLine("Which number do you want to see Multiplication Table of:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Upto how Many Terms would you like to see multiplication table of {firstNumber}:");
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= secondNumber; i++)
            {
                Console.WriteLine($"{firstNumber} * {i} = {firstNumber * i}");
            }
        }

        public void ArrayMultiplication()
        {
            int mul = 1;
            Console.Write("How many numbers do you want to find the Multiplication of:");
            int number = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[number];
            Console.WriteLine("Enter your Numbers:");

            for (int i = 0; i < number; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                mul = mul * arrayNum[i];
            }
            Console.WriteLine($"Multiplication of given numbers is: {mul}");
        }
    }
}
