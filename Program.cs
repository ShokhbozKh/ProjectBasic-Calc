using System;
namespace ProjectBasic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                //Calculator
                Console.Write("Enter First number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Exit Enter to 0: ");

                Console.Write("Enter +, -, *, / : ");
                char res = char.Parse(Console.ReadLine());

                Console.Write("Enter Second number: ");
                int number2 = int.Parse(Console.ReadLine());

                if (res == '0') Console.WriteLine("Xayr "); break;

                switch (res)
                {
                    case '+':
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                        break;
                    case '-':
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                        break;
                    case '*':
                        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                        break;
                    case '/':
                        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                        break;
                    default:
                        Console.WriteLine($" bunday amal yuq");
                        break;
                }
                Console.WriteLine();
            }

        }
    }

}
