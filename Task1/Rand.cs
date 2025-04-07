using System;

namespace LogicalProject
{
    class Rand
    {
        private Random random = new Random();

        public bool GenerateRandomBool()
        {
            return random.Next(2) == 1;
        }
    }
}