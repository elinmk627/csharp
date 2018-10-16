using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double avg = 0.0;
            string str;
            
            for(int i=1; i<=10; i++)
            {
                Console.Write("숫자-{0} : ", i);
                str = Console.ReadLine();
                sum += int.Parse(str);
                avg = (double)sum / i;
            }
            Console.WriteLine("합 : {0}", sum);
            Console.WriteLine("평균 : {0}", avg);
        }
    }
}
