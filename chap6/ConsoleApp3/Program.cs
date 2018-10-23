using System;
using System.Threading;

namespace ThreadInterrupt {
    class Program {
        public static Thread sleeperThread;

        public static void Main(string[] args) {
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            // sleeperThread는 ThreadToSleep메소드를 실행하는 스레드

            sleeperThread.Start();
            sleeperThread.Interrupt();
        }

        private static void ThreadToSleep() {
            int i = 0;
            while(true) {
                Console.WriteLine("[Sleeper : " + i++ + "]");
                if(i==9) {
                    try {
                        Console.WriteLine("i가 9가되어 1초쉼");
                        Thread.Sleep(1000);     // 자동으로 Interrupt실행되어 catch로 빠짐
                    }
                    catch(ThreadInterruptedException e) {
                        Console.WriteLine("ThreadInterruptedException");
                        Environment.Exit(0);    // 직접죽일수 있음
                    }
                }
            }
        }
    }
}
