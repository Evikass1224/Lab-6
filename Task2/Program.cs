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
        }
    }
}