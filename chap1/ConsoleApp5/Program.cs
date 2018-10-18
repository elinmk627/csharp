using System;

namespace ConsoleApp5
{
    class AsTest
    {
        class Emp
        {
            public override string ToString()
            {
                return "Emp";
            }
        }
        class Programmer : Emp { }
        class Program  
        {
            static void Main()
            {
                Programmer p = new Programmer();

                Emp e = p as Emp;
                if(e!=null)
                {
                    Console.WriteLine(e.ToString());     // 출력: Emp
                }
            }
        }
    }
}
