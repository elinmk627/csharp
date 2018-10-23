using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// [예제] 메소드기반 쿼리식, 람다식을 이용하여 최대, 최소, 배열에서 홀수의 합, 홀수의 개수,
// 50보다 큰 수의 개수를 구하시오.
namespace ConsoleApp21 {
    class Program     {
        static void Main(string[] args) {

            int[] scores = { 30, 54, 64, 54, 99, 11 };

            int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();
            Console.WriteLine("{0} 홀수의합", oddScoreSum);

            int oddCount = scores.Where(n => n % 2 == 1).Count();
            Console.WriteLine("{0} 홀수의개수", oddCount);

            int Count = scores.Where(n => n > 50).Count();
            Console.WriteLine("{0} 50보다큰수의개수", Count);

            int Max = scores.Max();
            Console.WriteLine("{0} 배열의 최대값", Max);

            int Min = scores.Min();
            Console.WriteLine("{0} 배열의 최소값", Min);
        }
    }
}
