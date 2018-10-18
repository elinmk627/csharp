using System;

namespace ConsoleApp5 {
   class OnjMath {
        internal static double MultipleByTwo(double value) {
            return value * 2;
        }
        internal static double Square(double value) {
            return value * value;
        }
    }

    delegate double OnjDouble(double x);    // 델리게이트 선언
    class DelegateTest2  {
        static void Main(string[] args) {
            // Delegate를 배열로 지정
            OnjDouble[] op =
                {
                    new OnjDouble(OnjMath.MultipleByTwo),
                    new OnjDouble(OnjMath.Square)
                };

            for(int i=0; i<op.Length; i++) {
                Console.WriteLine("op[{0}] 호출:",i);
                CallDelegate(op[i], 3.0);   //Delegate를 다른 메소드의 인자로 넘긴다.
                Console.WriteLine();
            }
        }

        static void CallDelegate(OnjDouble func, double value) {
            //넘겨받은 Delegate를 실행 한다.
            double ret = func(value);
            Console.WriteLine("입력된 값은 {0}이고 결과는 {1} 이다", value, ret);
        }
    }
}
