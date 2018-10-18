using System;

namespace ConsoleApp46 {
    public class AddClass1 {
        public int val;
        public static AddClass1 operator +(AddClass1 op1, AddClass1 op2) {
            AddClass1 obj = new AddClass1();
            obj.val = op1.val + op2.val;
            return obj;
        }
    }
    
    class Test {
        static void Main() {
            AddClass1 op1 = new AddClass1();   op1.val = 1;
            AddClass1 op2 = new AddClass1();   op2.val = 2;
            AddClass1 op3 = op1 + op2;
            Console.WriteLine("op1 + op2 = {0}", op3.val);
        }
    }
}
