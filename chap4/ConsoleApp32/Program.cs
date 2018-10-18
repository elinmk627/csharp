using System;
using System.Collections.Generic;

namespace ConsoleApp32 {
    class Program {
        static void Main(string[] args) {
            // 4행2열
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();

            foreach (int i in twoDim) {
                Console.Write(i);
            }
        }
    }
}
