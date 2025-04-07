using System;

namespace LogicalProject
{
    class InputDataWithCheck
    {
        static public bool InputBoolWithValidation(string message)
        {
            bool validInput;
            bool result;
            do
            {
                Console.WriteLine(message);
                validInput = bool.TryParse(Console.ReadLine(), out result);

                if (!validInput)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите true или false.");
                }
            }
            while (!validInput);
            return result;
        }
    }
}
