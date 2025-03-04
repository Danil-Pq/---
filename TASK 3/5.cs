using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int count = 0;
        for (int i = 1; i <= 100000; i++)
        {
            if (IsGoodNumber(i))
            {
                count++;
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"Количество 'хороших' чисел: {count}");
        Console.WriteLine($"Время выполнения: {stopwatch.Elapsed}");
    }

    static bool IsGoodNumber(int number)
    {
        int sumOfDigits = number.ToString().Sum(c => c - '0');
        return sumOfDigits != 0 && number % sumOfDigits == 0;
    }
}

Вывод
Количество 'хороших' чисел: 11872
Время выполнения: 00:00:00.0343334
