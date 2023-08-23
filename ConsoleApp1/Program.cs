using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string userDecision;
            bool validStatement;

            Console.WriteLine("\nWelcome to my calculator app ");
            Console.WriteLine(GreetingMessage());

            do
            {
                Console.WriteLine("\nWhat calculation would you like to do?");
                Console.WriteLine("1.  Addition");
                Console.WriteLine("2.  Substraction");
                Console.WriteLine("3.  Multiplication");
                Console.WriteLine("4.  Multiplication Table");
                Console.WriteLine("5.  Division");
                Console.WriteLine("6.  Square");
                Console.WriteLine("7.  Square Root");
                Console.WriteLine("8.  Cube");
                Console.WriteLine("9.  Cube Root");
                Console.WriteLine("10. Sum of numbers");
                Console.WriteLine("11. Difference of numbers");
                Console.WriteLine("12. Multiplication of numbers");
                Console.WriteLine("13. Average of numbers");

                do
                {
                    Console.Write("\nEnter the Number corresponding to your task according to above list:");
                    String userInput = Console.ReadLine();
                    Console.WriteLine();

                    if (userInput != null && int.TryParse(userInput, out int options))
                    {
                        switch (options)
                        {
                            case 1:
                                Addition();
                                break;
                            case 2:
                                Substraction();
                                break;
                            case 3:
                                Multiplication();
                                break;
                            case 4:
                                MultiplicationTable();
                                break;
                            case 5:
                                Division();
                                break;
                            case 6:
                                Square();
                                break;
                            case 7:
                                SquareRoot();
                                break;
                            case 8:
                                Cube();
                                break;
                            case 9:
                                CubeRoot();
                                break;
                            case 10:
                                Console.Write("How many numbers do you want to find the sum of:");
                                int number = int.Parse(Console.ReadLine());
                                int sum = NSum(number);
                                Console.WriteLine($"Sum of given numbers is: {sum}");
                                break;
                            case 11:
                                NDiff();
                                break;
                            case 12:
                                NMultiplication();
                                break;
                            case 13:
                                Average();
                                break;
                            default:
                                Console.WriteLine("Invalid Input!!!!!");
                                break;
                        }
                        validStatement = true;
                    }
                    else if (userInput == "")
                    {
                        Console.WriteLine("Please Enter a number!!!!!");
                        validStatement = false;
                    }
                    else
                    {
                        Console.WriteLine("Given input has to be an integer!!!!!");
                        validStatement = false;
                    }
                } while (validStatement != true);

                Console.WriteLine("\nDo you want to perform other calculations(y/n)?");
                userDecision = Console.ReadLine().ToLower();
            } while (userDecision == "y");
            Console.WriteLine("\nHave a nice day!!!!!");
        }

        public static string GreetingMessage()
        {
            int hour = int.Parse(DateTime.Now.ToString("HH"));

            if (hour >= 0 && hour < 12)
                return " *** Good Morning User *** ";
            else if (hour >= 12 && hour <= 17)
                return " *** Good Afternoon User *** ";
            else
                return " *** Good Evening User *** ";
        }

        public static void Addition()
        {
            Console.WriteLine("Enter two numbers you want to add");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }

        public static void Substraction()
        {
            Console.WriteLine("Enter two numbers you want to Substract");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }

        public static void Multiplication()
        {
            Console.WriteLine("Enter two numbers you want to Multiply");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }


        public static void MultiplicationTable()
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

        public static void Division()
        {
            Console.WriteLine("Enter Dividend");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisior");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        }

        public static void Square()
        {
            Console.WriteLine("Enter number you want to find square of:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Square of {number} is {number * number}");
        }

        public static void SquareRoot()
        {
            Console.WriteLine("Enter number you want to find square root of:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Square root of {number} is {Math.Sqrt(number)}");
        }

        public static void Cube()
        {
            Console.WriteLine("Enter number you want to find Cube of:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cube of {number} is {number * number * number}");
        }

        public static void CubeRoot()
        {
            Console.WriteLine("Enter number you want to find Cube root of:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Square root of {number} is {Math.Cbrt(number)}");
        }

        public static int NSum(int number)
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

        public static void NDiff()
        {
            int diff, temp;

            Console.Write("How many numbers do you want to find the difference of:");
            int number = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[number];
            Console.WriteLine("Enter your Numbers:");

            for (int i = 0; i < number; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine());
            }

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

            diff = arrayNum[0];

            for (int i = 1; i < number; i++)
            {
                diff = diff - arrayNum[i];
            }
            Console.WriteLine($"Difference of given numbers is: {diff}");
        }

        public static void NMultiplication()
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

        public static void Average()
        {
            Console.Write("How many numbers do you want to find the average of:");
            int number = int.Parse(Console.ReadLine());
            int sum = NSum(number);
            Console.WriteLine($"Average of given numbers is: {sum / number}");
        }
    }
}
