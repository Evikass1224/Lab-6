using System;

namespace TimeManagement
{
    class TimeInputHandler
    {
        static public Time GetTimeFromUser()
        {
            byte hours;
            byte minutes;
            bool ok1;
            bool ok2;

            do
            {
                Console.WriteLine("\nВведите часы (0-23):");
                ok1 = byte.TryParse(Console.ReadLine(), out hours);
                if (!ok1 || hours > 23)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите часы (0-23):");
                }
            } 
            while (!ok1 || hours > 23);

            do
            {
                Console.WriteLine("\nВведите минуты (0-59):");
                ok2 = byte.TryParse(Console.ReadLine(), out minutes);
                if (!ok2 || minutes > 59)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите минуты (0-59):");
                }
            } 
            while (!ok2 || minutes > 59);

            return new Time(hours, minutes);
        }
    }
}