using System;

namespace day1
{
    enum Day1
    {
        Monday, Thesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum Day2 : byte
    {
        Monday = 11, Thesday, Wednesday, Thursday, Friday, Saturday, Sunday = Monday + 100
    }
    public class EnumTest
    {
        static void Main()
        {
            Day1 whatDay = Day1.Sunday;
            Console.WriteLine("{0}", whatDay);          // Sunday
            Console.WriteLine("{0}", (int)whatDay);     // 6

            whatDay = (Day1)6;
            Console.WriteLine("{0}", whatDay);          // Sunday

            Day2 whatDay2 = Day2.Monday;
            Console.WriteLine("{0}", whatDay2);         // Monday
            Console.WriteLine("{0}", (byte)whatDay2);  // 11

            whatDay2 = (Day2)111;
            Console.WriteLine("{0}", whatDay2);         // Sunday            
        }
    }
}
