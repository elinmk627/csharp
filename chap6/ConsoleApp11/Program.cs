using System;

namespace ConsoleApp11 {
    class Program {
        static void Main(string[] args) {
            int k = 0;
            for(int i=0; i<3; i++) {
                for (int j=0; j<=i+k; j++) {
                    Console.Write("*");                    
                }
                k += 1;
                Console.WriteLine();
            }            
        }
    }
}
