using System;
using System.Threading;

namespace ConsoleApp1 {
    public class ThreadTest {
        public void FirstWork() {
            for(int i=0;i<100; i++) {
                Thread.Sleep(1000);             // 1초 쉬면서
                Console.Write("F{0} ", i);
            }
        }

        public void SecondWork() {
            for(int i=0; i<100; i++) {
                Thread.Sleep(1000);             // 1초 쉬면서
                Console.Write("S{0} ", i);
            }
        }

        [MTAThread] // 멀티스레드 동작한다는것. 안써도됨
        public static void Main() {
            ThreadTest t = new ThreadTest();        // CLR에 있는 Main Thread가 실행

            //Thread는 생성자에 ThreadStart형 Delegate를 인자로 받는다.
            Thread first = new Thread(t.FirstWork);
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Priority = ThreadPriority.Lowest;                 // 우선순위 약하게
            second.Priority = ThreadPriority.Highest;           // 우선순위 쎄게

            first.Start();
            second.Start();
        }
    }    
}
