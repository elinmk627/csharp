using System;

namespace ConsoleApp34 {
    class Program {
        static void Main() {
            foreach(int id in GetEmployeeIds()) {
                Console.WriteLine(id);
            }

            int[] employees = GetEmployeeIds();
            for(int i =0; i<employees.Length; i++) {
                Console.WriteLine(employees[i]);
            }
        }

        static int[] GetEmployeeIds() {
            int[] employees = new int[5];
            employees[0] = 1;
            employees[1] = 3;
            employees[2] = 5;
            employees[3] = 7;
            employees[4] = 8;
            return employees;
        }
    }   
}
