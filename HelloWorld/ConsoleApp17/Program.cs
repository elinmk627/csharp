using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("변환값: ");

            /* 
             case 1             
             */
            string str = Console.ReadLine();
            int num;
            int.TryParse(str, out num);

            int mok = num;
            int na = 0;
            string val = "";

            for (int i = 1; i > 0; i++)
            {
                na = mok % 2;             // 0, 1
                mok = mok / 2;            // 7, 3
                val += na;
                if (mok < 2)
                {
                    val = val + mok;
                    break;
                }
            }

            String reverse = new String(val.ToCharArray().Reverse().ToArray());
            Console.WriteLine("결과값: {0}", reverse);


            /*
             case 2
            string num = Console.ReadLine();
            int mok = int.Parse(num);
            string na = "";

            //while (mok > 0) {
            //    na = (mok % 2) + na;
            //    mok = mok / 2;
            //}

            for (int i = mok; mok > 0;)
            {
                na = (mok % 2) + na;
                mok = mok / 2;
            }
            Console.WriteLine(na);
            
             */
        }
    }
}
