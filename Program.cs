using System;

namespace Lesson3
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            //Задание1
            System.Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                b = a;
            }
            else if(a < b)
            {
                a = b;
            }
            else if(a == b)
            {
                a = 0;
                b = 0;
            }
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");
        }

    }
}