using System;

namespace Lesson3
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            // //Задание1
            // System.Console.WriteLine("Введите первое число:");
            // int a = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Введите второе число:");
            // int b = int.Parse(Console.ReadLine());

            // if(a > b)
            // {
            //     b = a;
            // }
            // else if(a < b)
            // {
            //     a = b;
            // }
            // else if(a == b)
            // {
            //     a = 0;
            //     b = 0;
            // }
            // System.Console.WriteLine($"a = {a}");
            // System.Console.WriteLine($"b = {b}");

            // // Задание2
            // System.Console.WriteLine("Добро пожатовать в калькулятор!");
            // System.Console.WriteLine("Введите первое число:");
            // int operand1 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Введите второе число:");
            // int operand2 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Введите операцию: +, -, *, /");
            // string sign = Console.ReadLine();
            // int result = 0;
            // switch (sign)
            // {
            //     case "+":
            //     {
            //         result = operand1 + operand2;
            //         System.Console.WriteLine(result);
            //         break;
            //     }
            //     case "-":
            //     {
            //         result = operand1 - operand2;
            //         System.Console.WriteLine(result);
            //         break;
            //     }case "*":
            //     {
            //         result = operand1 * operand2;
            //         System.Console.WriteLine(result);
            //         break;
            //     }case "/":
            //     {
            //         if(operand2 != 0)
            //         {
            //             result = operand1 / operand2;
            //             System.Console.WriteLine(result);
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("Деление на 0 нельзя!");
            //         }
            //         break;
            //     }
            //     default:
            //     {
            //         System.Console.WriteLine("Введите корректные данные!");
            //         break;
            //     }
            // }

            //Задание 3
            System.Console.WriteLine("Введите число: 0 - 100");
            int number = int.Parse(Console.ReadLine());
            if(number >= 0 && number <= 14)
            {
                System.Console.WriteLine($"Данное число находится в диапозоне 0 - 14");
            }
            else if(number >= 15 && number <= 35)
            {
                System.Console.WriteLine($"Данное число находится в диапозоне 15 - 35");
            }
            else if(number >= 36 && number <= 50)
            {
                System.Console.WriteLine($"Данное число находится в диапозоне 36 - 50");
            }
            else if(number >= 51 && number <= 100)
            {
                System.Console.WriteLine($"Данное число находится в диапозоне 51 - 100");
            }
            else
            {
                System.Console.WriteLine("Данное число не входит ни в один числовой промежуток!");
            }
        }
    }
}