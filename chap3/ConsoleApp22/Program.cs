using System;

namespace ConsoleApp22
{
    interface Dog
    {
        string name { get; set; }       // 속성
        void jitda();                       // 추상메소드
    }
     
    class Pudle : Dog { 
        public string name { get; set; }
        public void work() { Console.WriteLine(name + "가 일한다."); }
        public void jitda() { Console.WriteLine(name + " 짓다~~~~"); }       
    }

    class Jindo : Dog {
        public string name { get; set; }
        public void run() { Console.WriteLine(name + " 달린다."); }
        public void jitda() { Console.WriteLine(name + " 짓다~~~~"); }
    }

    class Program {
        static void Main(string[] args) {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();                      // 푸들푸들
            ((Pudle)p).work();           // 푸들이 일한다

            Dog j = new Jindo();
            j.name = "진도이";
            j.jitda();                       // 진도진도
            ((Jindo)j).run();              // 진도이 일한다
        }
    }
}
