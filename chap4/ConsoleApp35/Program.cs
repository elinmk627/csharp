using System;

namespace ConsoleApp35 {
    class Program {
        static void Main() {
            int[] teams = new int[3];
            teams[0] = 1;
            teams[1] = 2;
            teams[2] = 3;

            Employee employee = new Employee(teams);
            foreach (int team in employee.Teams) {
                Console.WriteLine(team);
            }
        }

        class Employee {
            int[] _teams;
            public Employee(int[] teams ) {
                _teams = teams;
            }

            public int[] Teams {
                get {
                    return _teams;
                }
            }
        }
    }
}
