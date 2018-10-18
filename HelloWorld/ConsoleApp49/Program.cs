using System;

namespace ConsoleApp49 {

    //일반화 클래스
    class DataStore<T> { 
        private T[] s = new T[10];
        public T this[int index] {
            get {
                if (index < 0 || index >= s.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                return s[index];
            }
            set {
                if (index < 0 || index >= s.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                s[index] = value;
            }
        }
    }

    class Program{
        static void Main(string[] args) {
            DataStore<string> ds1 = new DataStore<string>();
            ds1[0] = "One";
            ds1[1] = "Two";
            ds1[2] = "Three";

            for (int i = 0; i < 3; i++)
                Console.WriteLine(ds1[i]);

            DataStore<int> ds2 = new DataStore<int>();
            ds2[0] = 1;
            ds2[1] = 2;
            ds2[2] = 3;

            for (int i = 0; i < 3; i++)
                Console.WriteLine(ds2[i]);
        }
    }
}
