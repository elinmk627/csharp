using System;

namespace ConsoleApp13 {
    class Program  {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            bool flag = true;

            for(int i=2; i<=num; i++) {
                for(int j=2; j<i; j++) {
                    if(i%j == 0) {
                        flag = false;
                    }
                }
                if(flag == true) {
                    sum += i;
                }
                flag = true;
            }
            Console.WriteLine(sum);
        }
    }
}
