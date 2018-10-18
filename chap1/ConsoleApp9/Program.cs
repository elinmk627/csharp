using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            // int b = a.Value;
            // Console.WriteLine("Value of b is {0}", b);  // 에러 - 아래와같이 풀어서 사용가능

            int b;
            if (a.HasValue) b = a.Value;
            else b = 0;
            Console.WriteLine("Value of b is {0}", b);  // 0

            int c = a ?? 0;
            Console.WriteLine("Value of c is {0}", c);  // 0
            Console.ReadLine();
        }
    }
}