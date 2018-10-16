using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("출력을 원하는 구구단 단수 : ");
            string str = Console.ReadLine();
            int num = int.Parse(str);

            int i, j;
            for (i = 2; i <= 9; i++)
            {
                for (j = 1; j <= num; j++)
                {
                    Console.Write("{0}x{1}={2}", j ,i, i * j);
                    if (j != num) Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
