using System;

namespace TimeManagement
{
    class InputDataWithCheck
    {
        static public uint InputMinutesWithValidation(string message)
        {
            uint minutesToSubtract;
            bool ok;
            do
            {
                Console.WriteLine(message);
                ok = uint.TryParse(Console.ReadLine(), out minutesToSubtract);
                if (!ok || minutesToSubtract < 0)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите минуты (> 0): ");
                }
            } 
            while (!ok || minutesToSubtract < 0);
            return minutesToSubtract;
        }
    }
}
