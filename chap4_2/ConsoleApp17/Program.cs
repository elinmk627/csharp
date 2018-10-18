using System;

namespace ConsoleApp17 {
    class Program {
        static void Main() {
            Adder a = new Adder();
            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;
            int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            Console.ReadKey();
        }

        static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)  {
            Console.WriteLine("Multiple of five reached: {0}", e.Total);
        }
    }

    public class Adder {
        public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
        public int Add(int x, int y) {
            int iSum = x + y;
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null)) {
                OnMultipleOfFiveReached(null, new MultipleOfFiveEventArgs(iSum));
            }
            return iSum;
        }
    }

    public class MultipleOfFiveEventArgs : Adder {
        public MultipleOfFiveEventArgs(int iTotal) {
            Total = iTotal;
        }
        public int Total { get; set; }
    }
}
