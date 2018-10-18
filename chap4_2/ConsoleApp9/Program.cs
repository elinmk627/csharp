using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    1. 임의의 수를 콤마로 구분해서 Console.ReadLine()으로 입력 받은 후 델리게이트를
        이용하여 사칙연산을 구하는 프로그램을 델리게이트 체인 및 델리게이트 멀티 캐스팅을
        이용하여 구현하세요.     
 */
namespace ConsoleApp9 {

    delegate void OnjDelegate(int a, int b);
    class Program {
        static void Plus(int a, int b) {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Minus(int a, int b) {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        static void Multiplication(int a, int b) {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        static void Division(int a, int b) {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }

        static void Main() {
            Console.WriteLine("정렬할 숫자를 ,(콤마)로 구분하여 입력하세요.");
            string str = Console.ReadLine();
            string[] sArray = str.Split(',');
            int[] iArray = Array.ConvertAll(sArray, s => int.Parse(s));
            int a = iArray[0];
            int b = iArray[1];

            OnjDelegate CallBack1 = new OnjDelegate(Program.Plus);
            OnjDelegate CallBack2 = new OnjDelegate(Program.Minus);
            OnjDelegate CallBack3 = new OnjDelegate(Program.Multiplication);
            OnjDelegate CallBack4 = new OnjDelegate(Program.Division);
            OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;
            CallBack(a, b);
        }
    }
}
