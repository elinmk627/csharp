using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp4 {
    class Program : Form {
        Random r;
        public Program() {
            r = new Random();
            this.MouseWheel += new MouseEventHandler(OnjMouseWheel);
            this.MouseDown += new MouseEventHandler(OnjMouseDown);
        }

        //마우스 다운 이벤트 처리 메소드
        void OnjMouseDown(object sender, MouseEventArgs e) {
            //촤측 마우스 버튼 클릭이면
            if(e.Button == MouseButtons.Left) {
                //최대화, 최소화 버튼 보이기
                this.MaximizeBox = true;
                this.MinimizeBox = true;
                Color oldcolor = this.BackColor;
                //배경색을 임의의 색으로 변경
                this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }

            //우측 마우스 버튼 클릭이면
            if(e.Button == MouseButtons.Right) {
                //최대화, 최소화 버튼 숨기기
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
        }

        //마우스 휠 이벤트 처리 메소드
        void OnjMouseWheel(object sender, MouseEventArgs e) {
            //마우스휠 움직이는 것에 따라 윈도우 투명도 조절
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);
            Console.WriteLine("Opacity : {0}", this.Opacity);
        }

        static void Main(string[] args) {
            Application.Run(new Program());
        }
    }
}
