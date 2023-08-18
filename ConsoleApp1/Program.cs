using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            string isUserInput = Console.ReadLine();

            if (isUserInput == "Yes")
            {
                int firstInput =int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());

                int.Parse("Yes");
                int sum=firstInput+ secondInput;
                Console.WriteLine($"The output is :{sum}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Have a nice day!!");
            }

            Addition(5,6);
            
           
            
        }
        static int Addition(int firstInput,int secondInput)
        {
            int sum = firstInput + secondInput;
            return sum;
        }
        static int Multiplication(int firstInput, int secondInput)
        {
            int product = firstInput * secondInput;
            return product;
        }
        static int Subtraction(int firstInput, int secondInput)
        {
            int subtract = firstInput-secondInput;
            return subtract;
        }
        static int Division(int firstInput,int secondInput)
        {
            double divide = firstInput/secondInput;
            return divide;
        }
        
    }
}
