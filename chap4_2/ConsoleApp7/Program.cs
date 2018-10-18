using System;

// [예제3]Invoke를 이용한 델리게이트 호출
namespace ConsoleApp7 {
    class Program {

        delegate void Deli(string s);

        static void Main() {
            Deli d0 = (v) => Console.WriteLine(v);
            d0.Invoke("OJC");

            Deli d1 = new Deli(d);
            d1.Invoke("OJC");

            Deli d2 = d;
            d2.Invoke("OJC");
        }

        static void d(string s) {
            Console.WriteLine(s);
        }
    }
}
