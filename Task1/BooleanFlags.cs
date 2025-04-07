using System;

namespace LogicalProject
{
    //базовый класс
    class BooleanFlags
    {
        private bool flag1;
        private bool flag2;

        //конструктор с параметрами
        public BooleanFlags(bool flag1, bool flag2)
        {
            this.flag1 = flag1;
            this.flag2 = flag2;
        }

        //конструктор копирования
        public BooleanFlags(BooleanFlags f)
        {
            flag1 = f.flag1;
            flag2 = f.flag2;
        }

        public bool Flag1
        {
            get
            {
                return flag1;
            }
        }
        public bool Flag2
        {
            get
            {
                return flag2;
            }
        }

        //отрицание
        public void Negate()
        {
            flag1 = !flag1;
            flag2 = !flag2;
        }

        //перегрузка метода ToString()
        public override string ToString()
        {
            return $"flag1: {flag1}, \nflag2: {flag2}";
        }
    }
}
