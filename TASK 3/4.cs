using System;

class Student
{
    private string name;
    private int age;
    private int grade;

    public Student(string name, int age, int grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public void SetGrade(int value)
    {
        if (value >= 1 && value <= 5)
        {
            grade = value;
        }
        else
        {
            Console.WriteLine("Оценка должна быть от 1 до 5.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Оценка: {grade}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Иван", 20, 4);
        student1.DisplayInfo();

        student1.SetGrade(6); // Некорректная оценка
        student1.SetGrade(3); // Корректная оценка
        student1.DisplayInfo();
    }
}

Вывод
Имя: Иван, Возраст: 20, Оценка: 4
Оценка должна быть от 1 до 5.
Имя: Иван, Возраст: 20, Оценка: 3
