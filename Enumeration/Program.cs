using System;

namespace Enumeration
{
    public enum WeekDays 
    { 
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class Program
    {
        public static WeekDays MeetingDay { get; set; } = WeekDays.Thursday;
        static void Main(string[] args)
        {
            Console.WriteLine(MeetingDay);
            MeetingDay = WeekDays.Friday;
            Console.WriteLine(MeetingDay);

            foreach(int i in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(i + " : " + (WeekDays)i);
            }
            foreach(string s in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(s);
            }
            WeekDays d = (WeekDays)1;
            Console.WriteLine(d);
            WeekDays d2 = WeekDays.Thursday;
            Console.WriteLine(d2);
            Console.WriteLine("Hello World!");
        }
    }
}
