using System;

class Car
{
    public string Brand { get; }
    public int Year { get; }
    public int Mileage { get; private set; }

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
        Mileage = 0;
    }

    public void Drive(int km)
    {
        Mileage += km;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Год выпуска: {Year}, Пробег: {Mileage} км");
    }

    ~Car()
    {
        Console.WriteLine($"Объект автомобиля {Brand} уничтожен.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 2020);
        car.Drive(150);
        car.DisplayInfo();
    }
}

Вывод
Марка: Toyota, Год выпуска: 2020, Пробег: 150 км
