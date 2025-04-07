using System;

namespace LogicalProject
{
    class InputChoiceHandler
    {
        private Rand generator = new Rand();

        public void HandleInputChoice(out bool flag1, out bool flag2)
        {
            Console.WriteLine("Выберите метод ввода двух логических полей (1 или 2):");
            Console.WriteLine("1) Ввести с клавиатуры.");
            Console.WriteLine("2) Ввести случайным способом.");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите 1 или 2.");
            }

            if (choice == 1)
            {
                flag1 = InputDataWithCheck.InputBoolWithValidation("Введите значение для flag1 (true/false): ");
                flag2 = InputDataWithCheck.InputBoolWithValidation("Введите значение для flag2 (true/false): ");
            }
            else
            {
                flag1 = generator.GenerateRandomBool();
                flag2 = generator.GenerateRandomBool();
                Console.WriteLine($"\nСгенерированные значения: flag1 = {flag1}, flag2 = {flag2}");
            }
        }
    }
}
