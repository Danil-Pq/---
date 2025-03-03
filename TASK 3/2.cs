using System;
using System.Linq;

public static class Message
{
    public static void PrintWordsWithMaxLength(string message, int n)
    {
        var words = message.Split(' ');
        foreach (var word in words)
        {
            if (word.Length <= n)
            {
                Console.WriteLine(word);
            }
        }
    }

    public static string RemoveWordsEndingWith(string message, char endChar)
    {
        var words = message.Split(' ');
        var filteredWords = words.Where(word => !word.EndsWith(endChar.ToString()));
        return string.Join(" ", filteredWords);
    }

    public static string FindLongestWord(string message)
    {
        var words = message.Split(' ');
        return words.OrderByDescending(word => word.Length).FirstOrDefault();
    }
}

class Program
{
    static void Main()
    {
        string message = "Это тестовое сообщение для проверки методов класса Message.";

        Console.WriteLine("Слова с длиной не более 4:");
        Message.PrintWordsWithMaxLength(message, 4);

        Console.WriteLine("\nСообщение после удаления слов, оканчивающихся на 'е':");
        string filteredMessage = Message.RemoveWordsEndingWith(message, 'е');
        Console.WriteLine(filteredMessage);

        Console.WriteLine("\nСамое длинное слово в сообщении:");
        string longestWord = Message.FindLongestWord(message);
        Console.WriteLine(longestWord);
    }
}

Вывод
Слова с длиной не более 4:
Это
для

Сообщение после удаления слов, оканчивающихся на 'е':
Это для проверки методов класса Message.

Самое длинное слово в сообщении:
сообщение
