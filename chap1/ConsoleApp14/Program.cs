using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력숫자 : ");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int sum =0;

            Console.Write("10까지의 숫자 : ");
            for (int i=1; i<= num; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("10까지의 숫자합은 : {0}", sum);
        }
    }
}
