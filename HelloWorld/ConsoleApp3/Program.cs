using System;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    class TypecaseExample1
    {
        public static void Main()
        {
            int iSize = sizeof(int);
            Console.WriteLine("int형 바이트 길이 : {0}", iSize);

            Type myType1 = typeof(int);
            Console.WriteLine("typeof(int) : {0}", myType1);

            int i = 10;
            Type myType2 = i.GetType();
            Console.WriteLine("i.GetType() : {0}", myType2);

            int j = 99;     // 변수의 사이즈 구할때
            Console.WriteLine("Size of j : {0}", Marshal.SizeOf(j));
        }
    }
}
