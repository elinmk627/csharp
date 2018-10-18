using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(+3);                // 3
            Console.WriteLine(3+3);              // 6
            Console.WriteLine(3+ .3);            // 3.3
            Console.WriteLine("3" + "3");       // 33
            Console.WriteLine(3.0 + "3");       // 33

            // !는 피연산자를 부정하는 연산자
            Console.WriteLine(!true);             // False

            // ~: 비트 보수 연산을 수행, 각 비트를 반전
            byte x = 10;
            Console.WriteLine(~x);               // -11

            Console.WriteLine(unchecked((short)50000));     // overflow, -15536
        }
    }
}
