using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class ParamsTest
    {
        static void Main()
        {
            ParamsTest p = new ParamsTest();
            Console.WriteLine(p.Sum(1, 2));
            Console.WriteLine(p.Sum(1, 2, 3));

            // 명명된인수
            Console.WriteLine(p.Sum2(j:1, i:2));
            Console.WriteLine(p.Sum2(j:2));
        }

        int Sum(params int[] iArray)
        {
            int sum = 0;
            foreach (int i in iArray) sum += i;
            return sum;
        }

        int Sum2(int i=0, int j=0)      // i=0 : 선택적인수
        {
            Console.WriteLine("i={0}, j={1}", i, j);
            return i+j;
        }
    }
}
