using System;
using System.Threading;

namespace ConsoleApp2 {
    public class ThreadTest2  {
        bool sleep = false;

        //차단기가 내려간 상태
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        public void FirstWork() {
            for(int i=0; i<10; i++) {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);
                if(i==5)  {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉼...");
                    autoEvent.WaitOne();
                }
            }
        }

        public static void Main() {
            ThreadTest2 t = new ThreadTest2();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();
            while(t.sleep == false) { }     // Main이 true될때까지 대기
            Console.WriteLine("first를 깨웁니다. 2초후 깨어납니다.");
            Thread.Sleep(2000);
            autoEvent.Set();
        }
    }
}
