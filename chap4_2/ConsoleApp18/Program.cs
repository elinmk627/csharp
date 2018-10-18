using System;

namespace ConsoleApp18 {
    delegate void MyDelegate();

    public class MyClass  {
        public void Process() {
            Console.WriteLine("Process() begin");
            Console.WriteLine("Process() end");
        }
    }

    public class Test {
        static void Main(string[] args) {
            MyClass myClass = new MyClass();
            myClass.Process();
            //1
            //MyDelegate doAction = myClass.Process;
            //doAction();

            //2
            Action doAction = myClass.Process;
            doAction();
        }
    }
}
