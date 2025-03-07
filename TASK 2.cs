using System;
using System.Text.RegularExpressions;

class Program
{
    static bool ValidateEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }

    static bool ValidatePhoneNumber(string phone)
    {
        string pattern = @"^\+7\d{10}$";
        return Regex.IsMatch(phone, pattern);
    }

    static List<string> FindDates(string text)
    {
        string pattern = @"\b\d{2}\.\d{2}\.\d{4}\b";
        var matches = Regex.Matches(text, pattern);
        var dates = new List<string>();
        foreach (Match match in matches)
        {
            dates.Add(match.Value);
        }
        return dates;
    }

    static string ReplaceDigits(string text)
    {
        string pattern = @"\d";
        return Regex.Replace(text, pattern, "*");
    }

    static string[] SplitText(string text)
    {
        string pattern = @"[ ,.]+";
        return Regex.Split(text, pattern);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Проверка email-адреса");
            Console.WriteLine("2. Проверка номера телефона");
            Console.WriteLine("3. Поиск дат в формате dd.MM.yyyy");
            Console.WriteLine("4. Замена всех цифр на *");
            Console.WriteLine("5. Разбиение строки по запятым, точкам или пробелам");
            Console.WriteLine("0. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите email:");
                    string email = Console.ReadLine();
                    Console.WriteLine(ValidateEmail(email) ? "Email корректен." : "Email некорректен.");
                    break;

                case "2":
                    Console.WriteLine("Введите номер телефона:");
                    string phone = Console.ReadLine();
                    Console.WriteLine(ValidatePhoneNumber(phone) ? "Номер телефона корректен." : "Номер телефона некорректен.");
                    break;

                case "3":
                    Console.WriteLine("Введите текст для поиска дат:");
                    string text = Console.ReadLine();
                    var dates = FindDates(text);
                    Console.WriteLine("Найденные даты: " + string.Join(", ", dates));
                    break;

                case "4":
                    Console.WriteLine("Введите текст для замены цифр:");
                    string input = Console.ReadLine();
                    Console.WriteLine("Результат: " + ReplaceDigits(input));
                    break;

                case "5":
                    Console.WriteLine("Введите текст для разбиения:");
                    string inputText = Console.ReadLine();
                    var parts = SplitText(inputText);
                    Console.WriteLine("Результат: " + string.Join(" | ", parts));
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}
