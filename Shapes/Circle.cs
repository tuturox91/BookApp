using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle() { }
        public Circle(string name)
            : base(name) {}


        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", empName);
        }

        public override string ToString()
            => $"Name: {empName}";
    }
}