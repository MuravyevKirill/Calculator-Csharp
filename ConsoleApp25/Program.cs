using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            if(!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
                Console.WriteLine("* Вы ввели не число");
                return;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double secondNumber))
            {
                Console.WriteLine("* Вы ввели не число");
                return;
            }

            Console.Write("Введите оператор: ");
            string oper = Console.ReadLine();

            double result = 0;

            switch (oper)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Вы ввели не оператор");
                    return;
            }

            Console.WriteLine("Ответ: " + result);
            Console.ReadLine();
        }
    }
}
