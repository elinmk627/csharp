using System;

namespace ConsoleApp33 {
    class Program {
        static void Main(string[] args) {

            // This is a zero-element int array.
            var values1 = new int[] { };
            Console.WriteLine(values1.Length);    // null

            // This is a zero-element int array also.
            var value2 = new int[0];
            Console.WriteLine(value2.Length);       // 0
        }
    }
}
