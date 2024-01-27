using System;
using static System.Console;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Здравствуйте!\nВведите целое число: ");
            int n = int.Parse(ReadLine());
            bool divide = false;
            int i = 1;
            while (i < n)
            {
                if (n % i == 0 && i !=1 ) divide = true;
                i++;
            }
            if (divide) WriteLine("Число не является простым.");
            else WriteLine("Число является простым.");
        }
    }
}
