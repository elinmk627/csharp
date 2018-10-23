using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodQueryExam {
    class Program {
        static void Main(string[] args) {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //메소드 기반 쿼리식, 짝수를 내림차순 정렬하여 출력
            IEnumerable<int> q1 = numbers.Where(num => num % 2 == 0).OrderByDescending(n => n);
            foreach (int i in q1) Console.Write(i + " ");
            Console.WriteLine();

            //메소드 기반 쿼리식, 짝수의 합
            int sum = numbers.Where(num => num % 2 == 0).Sum();
            Console.WriteLine("Sum = " + sum);

            //메소드 기반 쿼리식, 짝수중 최대값
            int max = numbers.Where(num => num % 2 == 0).Max(); 
            Console.WriteLine("Max = " + max);

            //메소드 기반 쿼리식, 짝수의 평균값
            double avg = numbers.Where(num => num % 2 == 0).Average();
            Console.WriteLine("Avg = " + avg);

            //Aggregate는 주어진 연산의 결과를 포워드 하면서 진행된다
            // 1*2 한 후 결과를 3과 곱하고, 다시 결과를 4와 곱함
            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation = " + result);

            // 10은 SEED, 10+1 결과를 2와 더하고 다시 결과를 3과 더함
            result = numbers.Aggregate(10, (a, b) => a + b);
            Console.WriteLine("Aggregation with seed = " + result);

            // 짝수를 대상으로 2 * 4 한 후 결과를 6과 곱하고
            result = numbers.Where(num => num % 2 == 0).Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation.Where = " + result);

            Console.WriteLine("\n-------------");
        }
    }
}
