using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1;
                double num2;
                double result;

                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("BASIC BISH CALCULATOR 1.0");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                
                Console.Write("Enter number 1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option : ");
                Console.WriteLine("\t+ : Add"); // \t Adds a tab looks cleaner
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\t* : Multiply");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result : {num1} - {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result : {num1} / {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result : {num1} * {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
                Console.WriteLine("Would you like to continue ? Y = yes, N = no");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("KTHXBYE");

            
        }
    }
}
