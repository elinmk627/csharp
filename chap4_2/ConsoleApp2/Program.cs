using System;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Test
    {
        //User32.dll 파일안의 MessageBox 함수를 불러와서 사용하는 예이다. DllImport Attribute를
        //이용하여 사용할 코드가 포함되어 있는 DLL을 넘겨주고 extern 키워드를 통해 사용하려고 하는
        //메소드가 외부에 있음을 알린다. 이렇게 하면 닷넷 환경 밖에서 개발된 코드들도 C#안에서 쓸 수 있다.
        [DllImport("User32.Dll")]
        public static extern int MessageBox(int h, string m, string c, int type);
        static void Main()
        {
            MessageBox(0, "Hello!", "In C#", 0);
        }
    }
}
