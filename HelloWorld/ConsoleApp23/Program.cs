using System;

namespace ConsoleApp23 { 
    class A {     
        protected A() {  }
        ~A() {        // finalize() 메소드
            Console.WriteLine("A소멸~");
        }
    }

    class B : A {
        public B() { }
        static void Main() {
            B a = new B();      // object -> A -> B
            GC.Collect();
        }
    }
}
