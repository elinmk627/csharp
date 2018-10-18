using System;

namespace ConsoleApp29 {
    class Program {
        static void Swap(out int a, out int b) {
            a = 10;  b = 20;
            int tmp = a;  a = b;  b = tmp;
        }
        static void Main(string[] args) {
            int a = 10;  int b = 20;

            Console.WriteLine("a={0}, b={1}", a, b);
            Swap(out a, out b);
            Console.WriteLine("a={0}, b={1}", a, b);
        }
    }
}
