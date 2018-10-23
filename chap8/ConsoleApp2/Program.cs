using System;
using System.Windows.Forms;

namespace ConsoleApp2 {
    class OnjMessageFilter : IMessageFilter {
        public bool PreFilterMessage(ref Message m)  {
            //마우스 클릭시 필터링 시킴
            if (m.Msg == 0x201) {
                Console.WriteLine("마우스 클릭 필터링됨...");
                //필터에서 처리했으니 응용프로그램에서 처리안해도된다는 의미
                //Form에 걸려 있는 Click 이벤트 동작안함.즉 윈도우가 종료되지않는다
                //이 부분을 false로 바꾼 후 실행해 보라
                return true;
            }
            return false;
        }
    }

    class Program : Form  {
        static void Main(string[] args)  {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program p = new Program();
            p.Click += new EventHandler(p.Form_Click);
            Application.Run(p);
        }
        void Form_Click(object sender, EventArgs e) {
            Console.WriteLine("마우스 클릭 이벤트 발생...");
            Application.Exit();
        }
    }
}
