using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());
        int digitCount = CountDigits(number);
        Console.WriteLine($"Количество цифр в числе: {digitCount}");
    }

    static int CountDigits(int number)
    {
        return number.ToString().Length;
    }
}

Вывод
Введите число:
123
Количество цифр в числе: 3
