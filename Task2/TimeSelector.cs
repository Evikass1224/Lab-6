using System;

namespace TimeManagement
{
    class TimeSelector
    {
        static public Time GetCurrentTime()
        {
            Console.WriteLine("\nВыберите способ ввода времени:");
            Console.WriteLine("1) Ввести с клавиатуры");
            Console.WriteLine("2) Использовать текущее время");

            Time currentTime;
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите 1 или 2.");
            }

            if (choice == 1)
            {
                currentTime = TimeInputHandler.GetTimeFromUser();  //ввод времени с клавиатуры
            }
            else
            {
                //текущее время
                DateTime now = DateTime.Now;
                currentTime = new Time((byte)now.Hour, (byte)now.Minute);
            }

            return currentTime;
        }
    }
}