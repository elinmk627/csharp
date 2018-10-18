using System;
using System.Collections.Generic;
using System.Text;

// [예제4]이번에는 델리게이트 체인 예제
namespace deledatetest {

    delegate void OnjDelegate(int a, int b);

    class MainApp {
        static void Plus(int a, int b) {
            Console.WriteLine("{0} + {1} = {2}", a, b, a +b);
        }
        static void Minus(int a, int b) {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        void Multiplication(int a, int b) {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        void Division(int a, int b) {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        
        static void Main() {
            MainApp m = new MainApp();
            //OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
            //        new OnjDelegate(MainApp.Plus),
            //        new OnjDelegate(MainApp.Minus),
            //        new OnjDelegate(m.Multiplication),
            //        new OnjDelegate(m.Division));

            //OnjDelegate CallBack = new OnjDelegate(MainApp.Plus);
            //CallBack += new OnjDelegate(MainApp.Minus);
            //CallBack += new OnjDelegate(m.Multiplication);
            //CallBack += new OnjDelegate(m.Division);

            OnjDelegate CallBack1 = new OnjDelegate(MainApp.Plus);
            OnjDelegate CallBack2 = new OnjDelegate(MainApp.Minus);
            OnjDelegate CallBack3 = new OnjDelegate(m.Multiplication);
            OnjDelegate CallBack4 = new OnjDelegate(m.Division);
            OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;

            CallBack(4, 3);

        }
    }
}
