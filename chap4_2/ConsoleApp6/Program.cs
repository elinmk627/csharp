using System;

// 델리게이트 작성 방법
// 1. 선언
// 2. 생성
// 3. 호출

// 델리게이트는 메소드를 참조하고 있는 것으로
// 런타임시 델리게이트가 참조하는 메소드를 실행하고
// 구현을 동적으로 할 수 있는 콜백 함수를 구현하는 용도

namespace ConsoleApp6 {
    class Program {
        public delegate int MyDelegate(int i, int j);

        public static void Main() {
            // TakesADelegate 메소드를 부르면서 인자로 델리게이트를
            // 생성하고 델리게이트의 인자로는 참조할 메소드명을 넣어준다.
            TakesADelegate(new MyDelegate(Add));
            TakesADelegate(new MyDelegate(Minus));
            TakesADelegate(new MyDelegate(Gop));
            TakesADelegate(new MyDelegate(Nanugi));
        }

        public static void TakesADelegate(MyDelegate SomeFunction) {
            //컴파일 시점에 할일이 지정되지 않고 런타임중에
            //메소드 인자로 대입되는 델리게이트에 의해 할 일이 결정된다.
            Console.WriteLine(SomeFunction(1, 2));
        }

        public static int Add(int i, int j) {
            return i + j;
        }
        public static int Minus(int i, int j)
        {
            return i - j;
        }
        public static int Gop(int i, int j)
        {
            return i * j;
        }
        public static int Nanugi(int i, int j)
        {
            return i / j;
        }
    }
}
