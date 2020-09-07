using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    public class Hexagon : Shape, IPointy, IDraw3d
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", empName);
        }

        public void Draw3D()
        {
            Console.WriteLine("I draw Hexagon in 3D!");
        }

        public byte Points
        {
            get => 6;
        }

    }
}