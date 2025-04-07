using System;
using System.Drawing;

namespace LogicalProject
{
    //дочерний класс
    class BooleanFlagsWithTime : BooleanFlags
    {
        private DateTime creationTime;          //поле для хранения времени создания

        //конструктор с параметрами
        public BooleanFlagsWithTime(bool flag1, bool flag2) : base(flag1, flag2)
        {
            creationTime = DateTime.Now;
        }

        //конструктор копирования
        public BooleanFlagsWithTime(BooleanFlagsWithTime p) : base(p)
        {
            creationTime = p.creationTime;
        }


        //перегрузка метода ToString()
        public override string ToString()
        {
            return base.ToString() + $"\nВремя: {creationTime}";
        }

        //метод 1 для вычисления логического выражения
        public void BooleanExpression()
        {
            bool flag1 = Flag1;
            bool flag2 = Flag2;
            bool result;

            if (flag1 == flag2)
            {
                Console.WriteLine("\nВычисление !flag1 || flag2: ");
                result = !flag1 || flag2;
            }
            else
            {
                Console.WriteLine("\nВычисление (flag1 && !flag2) || (!flag1 && flag2): ");
                result = (flag1 && !flag2) || (!flag1 && flag2);
            }

            Console.WriteLine($"Результат вычислений: {result}");
        }

        //метод 2 проверка на равенство
        public bool AreFlagsEqual()
        {
            return Flag1 == Flag2;
        }
    }
}
