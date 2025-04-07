using System;

namespace TimeManagement
{
    class Program
    {
        static void Main()
        {
            Time currentTime = TimeSelector.GetCurrentTime();
            Console.WriteLine($"\nТекущее время: {currentTime.ToString()}");

            //ввод количества минут для вычитания
            uint minutesToSubtract = InputDataWithCheck.InputMinutesWithValidation("Введите количество минут для вычитания: ");

            Time newTime = currentTime.SubtractMinutes(minutesToSubtract);
            Console.WriteLine($"\nВремя после вычитания {minutesToSubtract} минут: {newTime.ToString()}");

            Console.WriteLine("\nТестирование методов класса Time:");

            //тестирование неявного преобразования в byte
            byte hoursAsByte = currentTime;
            Console.WriteLine($"\nНеявное преобразование часов в byte (минуты отбрасываются): {hoursAsByte}");

            //тестирование явного преобразования к bool
            bool isNotZero = (bool)currentTime;
            Console.WriteLine($"Явного преобразования к bool (true - если часы и минуты не равны нулю): {isNotZero}");

            //тестирование унарного оператора -
            Time negatedTime = -currentTime;
            Console.WriteLine($"\nУнарный оператор - (обнуление): " + negatedTime.ToString());

            //тестирование унарного оператора --
            Time decrementedTime = --currentTime; // Уменьшение минут
            Console.WriteLine($"Оператор -- (обнуление минут): " + decrementedTime.ToString());

            //ввод Time1 и Time2
            Console.WriteLine("\nВведите время 1: ");
            Time Time1 = TimeSelector.GetCurrentTime();
            Console.WriteLine($"\nВремя 1: {Time1}");

            Console.WriteLine("\nВведите время 2: ");
            Time Time2 = TimeSelector.GetCurrentTime();
            Console.WriteLine($"\nВремя 2: {Time2}");

            //тестирование бинарных операций == и !=
            bool areEqual = Time1 == Time2;
            Console.WriteLine($"\nTime1 == Time2: {areEqual}");

            bool areNotEqual = Time1 != Time2;
            Console.WriteLine($"Time1 != Time2: {areNotEqual}");

        }
    }
}