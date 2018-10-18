using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48 {
    // 일반화 클래스 정의
    class Ojc<T> {
        //외부에서 접근못하도록 private으로 배열을 정의하고
        //배열의 값은 인덱스를 통해 다루도록 한다.
        //배열의 타입은 Ojc를 사용하는 시점에 정의 ==> Generic
        private T[] ojcArr = new T[10];

        //Generic을 이용하여 인덱서를 정의하자.
        public T this[int i] {
            get { return ojcArr[i]; }
            set { ojcArr[i] = value;  }
        }
    }

    class Program {
        static void Main(string[] args) {
            Ojc<string> ojc1 = new Ojc<string>();
            ojc1[0] = "Hello, OJC";
            System.Console.WriteLine(ojc1[0]);

            Ojc<int> ojc2 = new Ojc<int>();
            ojc2[0] = 999;
            System.Console.WriteLine(ojc2[0]);
        }
    }
}
