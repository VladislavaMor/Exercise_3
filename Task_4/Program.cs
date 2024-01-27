using System;
using static System.Console;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Здравствуйте!\nВведите длину последовательности: ");
            int n = int.Parse(ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                Write($"Введите {i+1}-е число последовательности: ");
                int number = int.Parse(ReadLine());
                if (number < min) min = number;
            }
            WriteLine($"Наименьшее число в последовательности: {min}.");
        }
    }
}