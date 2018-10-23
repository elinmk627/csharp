using System;

namespace ConsoleApp9 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            string result = "";

            if(num%2==1) {
                result = "홀수";
            } else {
                result = "짝수";
            }
            Console.WriteLine("결과 : {0}", result);
        }
    }
}
