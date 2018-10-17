using System;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        public void Draw() {
            Pen p = new Pen(Color.Red);
        }

        double radius;
        public Circle() {
            this.radius = 0;
        }

        public Circle(int r) {
            this.radius = r;
        }

        public double Area() {
            return Math.PI * (radius * radius);
        }        
    }
}
