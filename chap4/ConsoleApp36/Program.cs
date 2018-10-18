using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[2];
            array[0] = 10;
            array[1] = 3021;

            Test(array);   // 출력
            Test(null);
            Test(new int[0]);
        }

        static void Test(int[] array)
        {
            if(array != null && array.Length >0)
            {
                int first = array[0];
                Console.WriteLine(first);
            }
        }
    }
}
