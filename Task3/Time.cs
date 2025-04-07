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

        //унарный оператор для обнуления часов и минут
        public static Time operator-(Time time)
        {
            return new Time(0, 0);
        }

        //унарный оператор для обнуления минут
        public static Time operator--(Time time)
        {
            return new Time(time.hours, 0);
        }

        //неявная операция (минуты отбрасываются)
        public static implicit operator byte(Time time)
        {
            return time.hours; 
        }

        //явная операция (true - если часы и минуты не равны нулю)
        public static explicit operator bool(Time time)
        {
            return time.hours != 0 && time.minutes != 0;
        }

        //бинарная операция ==
        public static bool operator==(Time left, Time right)
        {
            return (left.minutes == right.minutes) && (left.hours == right.hours);
        }

        //бинарная операция !=
        public static bool operator!=(Time left, Time right)
        {
            return (left.minutes != right.minutes) || (left.hours != right.hours);
        }

        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}";
        }
    }
}
