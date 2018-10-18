using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp43 {
    interface IEquatable<T> {
        bool Equals(T obj);
    }

    public class Emp : IEquatable<Emp> {
        public string name { get; set; }
        public int sabun { get; set; }
        
        public bool Equals(Emp e) {
            if (this.name == e.name && this.sabun == e.sabun) {
                return true;
            }
            else {
                return false;
            }
        }
    }

    public class Car : IEquatable<Car> {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        
        public bool Equals(Car car) {
            if (this.Maker == car.Maker && this.Model == car.Model && this.Year == car.Year) {
                return true;
            }
            else {
                return false;
            }
        }
    }

    public class CarTest {
        static void Main() {
            Car c1 = new Car() {
                Maker = "현대",
                Model = "그랜저",
                Year = "2016"
            };

            Car c2 = new Car() {
                Maker = "현대",
                Model = "그랜저",
                Year = "2015"
            };

            if (c1.Equals(c2)) {
                Console.WriteLine("c1와 c2는 같다.");
            }
            else {
                Console.WriteLine("c1와 c2는 다르다.");
            }

            Emp e1 = new Emp() {
                name = "홍길이",
                sabun = 1004
            };

            Emp e2 = new Emp() {
                name = "홍길이",
                sabun = 1004
            };

            if (e1.Equals(e2)) {
                Console.WriteLine("e1와 e2는 같다.");
            }
            else {
                Console.WriteLine("e1와 e2는 다르다.");
            }
        }
    }
}
