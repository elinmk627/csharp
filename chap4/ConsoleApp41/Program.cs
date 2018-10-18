using System;

namespace ConsoleApp41 {
    class Test<T> {
        public T Sum(T i, T j) {
            return (dynamic)i + (dynamic)j;
        }
    }

    class TestMain {
        static void Main() {
            Test<int> t = new Test<int>();
            int i = 1;  int j = 2;
            Console.WriteLine("{0} + {1} = {2}", i, j, t.Sum(i, j));

            Test<float> t1 = new Test<float>();
            float f1 = 1.0f;  float f2 = 2.0f;
            Console.WriteLine("{0:f} + {1:f} = {2:f}", f1, f2, t1.Sum(f1, f2));
        }
    }
}
