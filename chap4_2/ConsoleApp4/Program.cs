using System;

namespace ConsoleApp4 {
    public class Delegate1 {
        public static void Main(string[] args) {
            Action<int, int> myMethod = 
                (i, j) => Console.WriteLine(i + j);
            myMethod(10, 30);
        }        
    }
}
