using System;

namespace ConsoleApp10 {

    public delegate void Callback();
    class Program {
        static void Main(string[] args) {
            MyClass my = new MyClass();
            my.MyMethod1();
            my.MyMethod2();
            Console.WriteLine("------------");

            my.GetCallback(new Callback(my.MyMethod1));
            my.GetCallback(new Callback(my.MyMethod2));
        }        
    }

    public class MyClass {
        public MyClass() { }        
        public void GetCallback(Callback callBack) {
            callBack();
        }
        public void MyMethod1() {
            Console.WriteLine("My Method1");
        }
        public void MyMethod2() {
            Console.WriteLine("My Method2");
        }        
    }
}
