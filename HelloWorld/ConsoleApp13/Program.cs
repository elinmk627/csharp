using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 4 6 8 10 출력
            for(int i=1; i<=10; i++)
            {
                if(i%2==0)
                    Console.Write(i + " ");
            }
        }
    }
}
