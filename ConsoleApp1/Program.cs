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

            Addition addition = new Addition();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();
            ToThePower toThePower = new ToThePower();
            Division division = new Division();

            do
            {
                ShowMenu();

                do
                {
                    Console.Write("\nEnter the Number corresponding to your task according to above list:");
                    string? userInput = Console.ReadLine();
                    Console.WriteLine();

                    if (userInput != null && int.TryParse(userInput, out int options))
                    {
                        switch (options)
                        {
                            case 1:
                                addition.Add();
                                break;

                            case 2:
                                substraction.Subs();
                                break;

                            case 3:
                                multiplication.Multiply();
                                break;

                            case 4:
                                multiplication.MultiplicationTable();
                                break;

                            case 5:
                                division.Divide();
                                break;

                            case 6:
                                Console.WriteLine("Enter number you want to find square of:");
                                int number = int.Parse(Console.ReadLine());

                                int squaredNumber = toThePower.PowerCalculation(number, 2);
                                Console.WriteLine($"Square of {number} is {squaredNumber}");
                                break;

                            case 7:
                                Console.WriteLine("Enter number you want to find square root of:");
                                number = int.Parse(Console.ReadLine());

                                double squareRoot = toThePower.PowerCalculation(number, 0.5);
                                Console.WriteLine($"Square root of {number} is {squareRoot}");
                                break;

                            case 8:
                                Console.WriteLine("Enter number you want to find Cube of:");
                                number = int.Parse(Console.ReadLine());

                                int cubedNumber = toThePower.PowerCalculation(number, 3);
                                Console.WriteLine($"Cube of {number} is {cubedNumber}");
                                break;

                            case 9:
                                Console.WriteLine("Enter number you want to find Cube root of:");
                                number = int.Parse(Console.ReadLine());

                                double cubeRoot = toThePower.PowerCalculation(number, 0.3);
                                Console.WriteLine($"Cube root of {number} is {cubeRoot}");
                                break;

                            case 10:
                                Console.Write("How many numbers do you want to find the sum of:");
                                number = int.Parse(Console.ReadLine());

                                int sum = addition.ArraySum(number);
                                Console.WriteLine($"Sum of given numbers is: {sum}");
                                break;

                            case 11:
                                substraction.ArrayDiff();
                                break;

                            case 12:
                                multiplication.ArrayMultiplication();
                                break;

                            case 13:
                                addition.Average();
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

        public static void ShowMenu()
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
    }
}
