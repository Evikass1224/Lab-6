using System;

namespace TimeManagement
{
    class Time
    {
        private byte hours;
        private byte minutes;

        //конструктор
        public Time(byte hours, byte minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        //метод вычитания минут из времени
        public Time SubtractMinutes(uint minutes)
        {
            int totalMinutes = this.hours * 60 + this.minutes;
            totalMinutes = totalMinutes - (int)minutes;

            totalMinutes = (totalMinutes % 1440 + 1440) % 1440;

            //новые часы и минуты
            byte newHours = (byte)(totalMinutes / 60);
            byte newMinutes = (byte)(totalMinutes % 60);

            return new Time(newHours, newMinutes);
        }

        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}";
        }
    }
}
