using System;

namespace ConsoleApp50 {
    class DataStore {
        private string[] strArr = new string[10]; // internal data storage
        public DataStore() { }
        public string this[int index] {
            get {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                return strArr[index];
            }
            set {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                strArr[index] = value;
            }
        }

        public string this[string name] {
            get {
                foreach (string s in strArr) {
                    if (s.ToLower() == name.ToLower())
                        return s;
                }
                return null;
            }
        }
    }

    class Program {
        static void Main(string[] args)  {
            DataStore strStore = new DataStore();
            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";
            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["two"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["FOUR"]);
        }
    }
}
