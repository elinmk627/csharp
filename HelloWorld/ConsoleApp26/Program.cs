using System;

namespace ConsoleApp26
{
    class Bubble
    {
        static void Main()
        {
            Console.WriteLine("정렬할 숫자를 ,(콤마)로 구분하여 입력하세요.");
            string str = Console.ReadLine();
            string[] sArray = str.Split(',');
            int[] iArray = Array.ConvertAll(sArray, s => int.Parse(s));
            int tmp;

            for (int i = 1; i < iArray.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (iArray[j] > iArray[i]) {
                        tmp = iArray[i];
                        iArray[i] = iArray[j];
                        iArray[j] = tmp;
                    }
                }
            }
            Console.Write("버블정렬후 배열 : ");
            foreach (int y in iArray) {
                Console.Write(y + " ");
            }            
        }
    }

}
