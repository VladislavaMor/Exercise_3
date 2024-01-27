using System;
using static System.Console;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Здравствуйте!\nВведите количество ваших карт: ");
            int n = int.Parse(ReadLine());
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                Write($"Введите номинал {i+1}-ой карты: ");
                string card = ReadLine();
                switch (card)
                {
                        case "1": sum +=  int.Parse(card); break;
                        case "2": sum += int.Parse(card); break;
                        case "3": sum += int.Parse(card); break;
                        case "4": sum += int.Parse(card); break;
                        case "5": sum += int.Parse(card); break;
                        case "6": sum += int.Parse(card); break;
                        case "7": sum += int.Parse(card); break;
                        case "8": sum += int.Parse(card); break;
                        case "9": sum += int.Parse(card); break;
                        case "J": sum += 10; break;
                        case "Q": sum += 10; break;
                        case "K": sum += 10; break;
                        case "T": sum += 10; break;
                        default: WriteLine("Введено некорректное значение.");i--; break;
                }
            }
            WriteLine($"Сумма всех карт равна {sum}");
        }
    }
}