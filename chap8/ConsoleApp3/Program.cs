using System;
using System.Windows.Forms;

namespace ConsoleApp3 {
    class Program : Form {
        //이벤트 처리 메서드, sender : 이벤트가 발생한 객체, 여기서는 Form,
        //MouseEventArgs는 Button(마우스의 어떤 버튼인지), Clicks(클릭한 횟수)
        //Delta(휠위 회전방햔과 거리), X(X좌표), Y(Y좌표)값을 가진다.

        public void MouseHandler(object sender, MouseEventArgs e) {
            Console.WriteLine("Sender : " + ((Form)sender).Text);
            Console.WriteLine("Sender : " + ((Form)sender).Name);
            Console.WriteLine("X:{0}, Y:{1}", e.X, e.Y);
            Console.WriteLine("Button:{0}, Clicks:{1}", e.Button, e.Clicks);
        }
        public Program(String title) {
            this.Text = title;
            this.Name = "윈폼";
            //MouseDown 이벤트 처리기 등록
            this.MouseDown += new MouseEventHandler(MouseHandler);
        }

        static void Main(string[] args) {
            Application.Run(new Program("마우스 이벤트 예제"));
        }
    }
}
