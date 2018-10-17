using System;

namespace ConsoleApp20
{
    class Emp
    {
        private string name;         // 멤버, 필드 / 객체지향의 캡슐화
        public string Name {        // 자동구현속성
            get; set;
        }

        // ________ string name; 
        // internal : 같은 어셈블리(프로젝트) 안에서 접근가능
        // protected : 자식클래스에서만 접근가능
        // protected < internal < public ==> getter/setter로 해결가능
    }

    class EmpTest {
        static void Main()  {
            Emp e = new Emp();
            e.Name = "Jeon";
            Console.WriteLine(e.Name);
        }
    }
}
