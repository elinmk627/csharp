using System;

namespace ConsoleApp24
{
    class MyBaseClass {
        public MyBaseClass() {
            Console.WriteLine(">>> MyBaseClass");
        }
        public MyBaseClass(int i) {
            Console.WriteLine(">>> MyBaseClass(int i)");
        }
    }

    class MyClass : MyBaseClass {
        public MyClass() {
            Console.WriteLine(">>> MyClass()");
        }
        public MyClass(int i) : base(i) {
            Console.WriteLine(">>> MyClass(int i)");
        }
        public MyClass(int i, int j) {
            Console.WriteLine(">>> MyClass(int i, int j)");
        }
        public MyClass(int i, int j, int k) : base(i) {
            Console.WriteLine(">>> MyClass(int i, int j, int k)");
        }
        public MyClass(int i, int j, int k, int l) : this(i, j) {
            Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
        }
    }

    class Test {
        static void Main() {
            MyClass m1 = new MyClass();             // MyBaseClass(), MyClass()
            MyClass m2 = new MyClass(1);           // MyBaseClass(int i), MyClass(int i)
            MyClass m3 = new MyClass(1, 2);        // MyBaseClass(), MyClass(int i, int j)
            MyClass m4 = new MyClass(1, 2, 3);     // MyBaseClass(int i), MyClass(int i, int j, int k)
            MyClass m5 = new MyClass(1, 2, 3, 4); // MyBaseClass(), MyClass(int i, int j), MyClass(int i, int j, int k, int l)
        }
    }
}
