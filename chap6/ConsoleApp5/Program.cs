using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// 1부터 50까지의 합을 5개의 쓰레드에 나누어서 실행하고자 한다.
// 첫번째 쓰레드는 1~10 까지의 합을, 두번째 쓰레드는 11~20 까지의 합을....다셋번째 쓰레드는
// 41~50 사이의 합을 구하는데 아래 두 방법으로 프로그램을 작성하세요. 

// # ThreadStart 델리게이트를 이용하여 작성
namespace ConsoleApp5 {
    class Program {
        static int mysum = 0;
        static void Sum(object n) {
            int sum = 0;
            int[] number = (int[])n;
            for(int i=number[0]; i<=number[1]; i++) {
                sum += i;
            }
            mysum += sum;
        }
        static void Main(string[] args) {
            Thread t1 = new Thread(new ThreadStart(() => Sum(new int[] { 1, 10 })));
            Thread t2 = new Thread(new ThreadStart(() => Sum(new int[] { 11, 20 })));
            Thread t3 = new Thread(new ThreadStart(() => Sum(new int[] { 21, 30 })));
            Thread t4 = new Thread(new ThreadStart(() => Sum(new int[] { 31, 40 })));
            Thread t5 = new Thread(new ThreadStart(() => Sum(new int[] { 41, 50 })));

            t1.Start();  t2.Start();  t3.Start();  t4.Start();  t5.Start();
            t1.Join();  t2.Join();  t3.Join();  t4.Join();  t5.Join();
            Console.WriteLine(mysum);
        }
    }
}
