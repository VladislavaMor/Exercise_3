using System;
using static System.Console;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите целое число: ");
            int a = int.Parse(ReadLine());

            if (a % 2 == 0) WriteLine($"Введенное число: {a}  - четное");
            else WriteLine($"Введенное число: {a} - нечетное.");
        }
    }
}