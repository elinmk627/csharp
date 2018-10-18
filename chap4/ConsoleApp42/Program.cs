using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp42 {

    // int 형 스택
    class Stack1 {
        int top = 0;
        int[] ar = new int[10];
        public void Push(int obj) {
            ar[top] = obj;
            top++;
        }
        public int Pop() {
            top--;
            return ar[top];
        }
    }

    // string 형 스택
    class Stack2 {
        int top = 0;
        string[] ar = new string[10];
        public void Push(string obj)  {
            ar[top] = obj;
            top++;
        }
        public string Pop() {
            top--;
            return ar[top];
        }
    }

    // Generic 스택
    class Stack3<T> {
        int top = 0;
        T[] ar = new T[10];

        public T Push(T obj) {
            ar[top] = (dynamic)obj;
            top++;
            return (dynamic)ar[top];
        }
        public T Pop() {
            top--;
            return (dynamic)ar[top];
        }
    }

    class StackTest {
        static void Main() {
            Stack1 s1 = new Stack1();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine(s1.Pop());    // 3
            Console.WriteLine(s1.Pop());    // 2
            Console.WriteLine(s1.Pop());    // 1

            Stack2 s2 = new Stack2();
            s2.Push("KOREA");
            s2.Push("대한민국");
            s2.Push("서울");
            Console.WriteLine(s2.Pop());    // 서울
            Console.WriteLine(s2.Pop());    // 대한민국
            Console.WriteLine(s2.Pop());    // KOREA

            Stack3<int> s3 = new Stack3<int>();
            s3.Push(11);
            s3.Push(22);
            s3.Push(33);
            Console.WriteLine(s3.Pop());    
            Console.WriteLine(s3.Pop());    
            Console.WriteLine(s3.Pop());   
        }
    }
}
