using System;
using Shapes;

namespace ShapeUser
{
    using System;
    using Shapes;

    public class ShapeUser
    {
        public static void Main()
        {
            Circle c = new Circle(1);
            Console.WriteLine("Area={0}", c.Area());
        }
    }
}
