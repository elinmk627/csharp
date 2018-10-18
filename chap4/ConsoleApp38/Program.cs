using System;
using System.Windows.Forms;

namespace ConsoleApp38
{
    class Program
    {
        static void Main()
        {
            char[] array = new char[5];
            array[0] = 'A';
            array[1] = 'B';
            array[2] = 'C';
            array[3] = 'D';
            array[4] = 'E';
            for(int i=0; i<array.Length; i++)
            {
                MessageBox.Show(array[i].ToString());
            }

            // A,B,C 만 출력되도록 괄호를 채워 주세요.
            Array.Resize(ref array, 3);
            for (int i = 0; i < array.Length; i++)
            {
                MessageBox.Show(array[i].ToString());
            }
        }
    }
}
