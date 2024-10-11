using System;

class Program
{
    // Точка входа в программу. 
    static void Main(string[] args)
    {
        // Вывод заголовка программы на консоль.
        Console.WriteLine("Temperature Converter");

        // Бесконечный цикл, который позволяет пользователю выполнять преобразования до тех пор, пока он не решит выйти из программы.
        while (true)
        {
            // Вывод меню с доступными вариантами преобразования.
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.WriteLine("3. Exit");

            // Получение данных с клавиатуры от пользователя.
            string choice = Console.ReadLine();

            // Использование оператора switch для обработки выбора пользователя.
            switch (choice)
            {
                // Если пользователь выбирает "1", то запускается метод ConvertCelsiusToFahrenheit.
                case "1":
                    ConvertCelsiusToFahrenheit();
                    break;
                // Если пользователь выбирает "2", то запускается метод ConvertFahrenheitToCelsius.
                case "2":
                    ConvertFahrenheitToCelsius();
                    break;
                // Если пользователь выбирает "3", то выводится сообщение о завершении работы программы, а затем программа завершается.
                case "3":
                    Console.WriteLine("Thank you for using the Temperature Converter. Goodbye!");
                    Environment.Exit(0);
                    break;
                // Если пользователь вводит цифру, которой нет в списке, то выводится сообщение об ошибке.
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Метод, который преобразует температуру из градусов Цельсия в градусы Фаренгейта.
    static void ConvertCelsiusToFahrenheit()
    {
        // Выводит запрос на ввод температуры в градусах Цельсия.
        Console.WriteLine("Enter the temperature in Celsius:");
        // Получает строковый ввод от пользователя и преобразует его в число с плавающей точкой.
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Вычисляет температуру в градусах Фаренгейта по формуле.
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Выводит результат преобразования на консоль.
        Console.WriteLine($"{celsius}°C is equivalent to {fahrenheit}°F.");
    }

    // Метод, который преобразует температуру из градусов Фаренгейта в градусы Цельсия.
    static void ConvertFahrenheitToCelsius()
    {
        // Выводит запрос на ввод температуры в градусах Фаренгейта.
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        // Получает строковый ввод от пользователя и преобразует его в число с плавающей точкой.
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Вычисляет температуру в градусах Цельсия по формуле.
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Выводит результат преобразования на консоль.
        Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius}°C.");
    }
}