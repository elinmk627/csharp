using System;

namespace ConsoleApp12 {

    //이벤트 게시자 클래스
    class EventPublisher {
        //public delegate void MyEventHandler(); 
        //이벤트 처리를 위한 델리게이트 정의
        public event EventHandler MyEvent;      // 이벤트 정의
        public void Do() {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null) {
                MyEvent(null, null);                    // 이벤트 발생
            }
        }
    }

    // 구독자 클래스
    class Subscriber {
        static void Main(string[] args) {
            EventPublisher p = new EventPublisher();

            //C#1.0 에서의 이벤트에 가입하는 방법
            p.MyEvent += new EventHandler(doAction);

            //C#2.0 이상에서 이벤트에 가입하는 방법
            p.MyEvent += doAction;

            //C#2.0 이상에서 delegate 를 이용한 무명함수로 이벤트에 가입하는 방법
            p.MyEvent += delegate (object sender, EventArgs e) {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };

            //C#3.0 이후 람다식을 이용한 무명함수로 이벤트에 가입하는 방법
            p.MyEvent += (sender, e) => {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };
            p.Do();         
        }

        static void doAction(object sender, EventArgs e) {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}
