using System;

namespace LogicalProject
{
    class Program
    {
        static void Main()
        {
            bool flag1, flag2;
            InputChoiceHandler choosingMethod = new InputChoiceHandler();
            choosingMethod.HandleInputChoice(out flag1, out flag2);

            BooleanFlags logicalObject1 = new BooleanFlags(flag1, flag2);
            Console.WriteLine("\nЗначения (через ToString): ");
            Console.WriteLine(logicalObject1.ToString());

            //инверсия
            Console.WriteLine("\nИнверсия: ");
            logicalObject1.Negate();
            Console.WriteLine(logicalObject1.ToString());

            //тестирование конструктора копирования
            Console.WriteLine("\nКопия базового класса: ");
            BooleanFlags logicalObject2 = new BooleanFlags(logicalObject1);
            Console.WriteLine(logicalObject2.ToString());

            Console.WriteLine("\nТестирование дочернего класса: ");
            choosingMethod.HandleInputChoice(out flag1, out flag2);

            //дочерний класс
            BooleanFlagsWithTime childObject = new BooleanFlagsWithTime(flag1, flag2);
            Console.WriteLine("\nЗначения: ");
            Console.WriteLine(childObject.ToString());

            //метод 1
            childObject.BooleanExpression();

            //метод 2
            bool areEqual = childObject.AreFlagsEqual();
            Console.WriteLine($"\nФлаги равны? {areEqual}");

            Console.WriteLine("\nИнверсия значений полей у дочернего класса:");
            childObject.Negate();
            Console.WriteLine(childObject.ToString());

            //тестирование конструктора копирования дочернего класса
            BooleanFlagsWithTime copiedChildObject = new BooleanFlagsWithTime(childObject);
            Console.WriteLine("\nКопия дочернего класса:");
            Console.WriteLine(copiedChildObject.ToString());
        }
    }
}
