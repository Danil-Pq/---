using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите логин:");
        string login = Console.ReadLine();

        if (IsLoginValid(login))
        {
            Console.WriteLine("Логин корректен.");
        }
        else
        {
            Console.WriteLine("Логин некорректен.");
        }
    }

    static bool IsLoginValid(string login)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";
        return Regex.IsMatch(login, pattern);
    }
}
