using System;
using System.Windows.Forms;

// [람다식을 이용한 무명함수로 이벤트 처리]
namespace ConsoleApp1 {
    class Program : Form {
        static void Main(string[] args) {
            Program form = new Program();
            form.Click += new EventHandler(
                (sender, eventArgs) => 
                {
                    Console.WriteLine("폼클릭 이벤트");
                    Application.Exit();
                });

            Console.WriteLine("윈도우 시작");
            Application.Run(form);                   
            Console.WriteLine("윈도우 종료");
        }
    }
}
