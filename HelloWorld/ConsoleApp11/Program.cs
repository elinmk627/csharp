using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();            // 키보드로 문자열로 입력받기
            //int num = int.Parse(str);                    // string -> int로 형변환
            int num;
            if(int.TryParse(str, out num)) Console.WriteLine("OK~") ;               // 참거짓을 돌려주는 형변환

            int sum = 0, i = 0;
            while (i++ < num)
            {
                if (i % 2 == 0)  sum += i;
            }
            Console.WriteLine("while. {0}까지 짝수의 합은 {1}", num, sum);
            

            sum = 0; i = 0;
            do
            {
                if (i % 2 == 0)  sum += i;
            }
            while (i++ < num);
            Console.WriteLine("dowhile. {0}까지 짝수의 합은 {1}", num, sum);


            sum = 0; i = 0;
            for(i=0; i<=num; i++)
            {
                if (i % 2 == 0)  sum += i;
            }
            Console.WriteLine("for. {0}까지 짝수의 합은 {1}", num, sum);
        }
    }
}
