using System;
using System.Windows.Forms;

namespace ConsoleApp6 {
    class MessageBoxTest {
        static void Main(string[] args) {
            // 가장 단순한 메시지 박스 
            MessageBox.Show("메시지");

            // 메시지 텍스트와 타이틀을 가지는 메시지 박스
            MessageBox.Show("메시지", "타이틀");

            // 두개의 버튼(yes, no)를 가지는 메시지 박스
            DialogResult result1 = MessageBox.Show("메시지", 
                    "타이틀(두 버튼 메시지박스)",
                    MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) Console.WriteLine("YES 클릭");
            else Console.WriteLine("NO 클릭");
            Console.WriteLine("1. -------------");

            // YesNoCancel 버튼, Question icon을 가지는 메시지 박스
            DialogResult result2 = MessageBox.Show("메시지",
                    "타이틀(Question 메시지박스, YesNoCancel)",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes) Console.WriteLine("YES 클릭");
            else if (result2 == DialogResult.No) Console.WriteLine("NO 클릭");
            else if (result2 == DialogResult.Cancel) Console.WriteLine("CANCEL 클릭");
            Console.WriteLine("2. -------------");

            // YesNoCancel 버튼, Question icon, Default 버튼을 가지는 메시지박스
            // 두번째 버튼인 NO버튼을 기본으로 포커스가 설정됨
            DialogResult result3 = MessageBox.Show("메시지",
                    "타이틀(Question,YesNoCancel,Default버튼)",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,            //?이아콘 표시
                    MessageBoxDefaultButton.Button2);

            // 타이틀, 메시지가 우측 정렬되어 표시되는 메시지 박스
            // 아래 true는 도움말 버튼 표시여부
            MessageBox.Show("메시지",
                "타이틀(메시지 우측 정렬,Error아이콘)",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error,       //X로표시
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                true);

            // exclamation icon을 가지는 메시지 박스
            MessageBox.Show("메시지",
                    "타이틀(exclamation icon)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);        //!아이콘 표시
        }
    }
}
