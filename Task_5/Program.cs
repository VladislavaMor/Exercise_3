using System;
using static System.Console;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Здравствуйте!\nВведите максимальное целое число диапазона: ");
            int n = int.Parse(ReadLine());
            Random rand = new Random();
            int number = rand.Next(n + 1);

            while(true)
            {
                Write("Введите число:");
                try
                {
                    int t = int.Parse(ReadLine());
                    if (t == number)
                    {
                        WriteLine("Вы угадали число!");
                        break;
                    }
                    else if (t < number) WriteLine("Загаданное число больше введенного.");
                    else WriteLine("Загаданное число меньше введенного.");
                }
                catch (Exception ex)
                {
                    WriteLine($"Загаданное число: {number}.");
                    break;
                }
            }
        }
    }
}