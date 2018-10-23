using System;

namespace ConsoleApp8 {
    class Program     {
        static void Main(string[] args) {
            int[] iArr = Array.ConvertAll((Console.ReadLine()).Split(','), i => int.Parse(i));
            int sum = 0;
            for(int i=0; i<iArr.Length; i++) {
                sum += iArr[i];
            }
            Console.WriteLine("총합 : {0}", sum);
        }
    }
}
