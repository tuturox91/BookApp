using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    public class ThreeDCircle : Circle, IDraw3d
    {
        public ThreeDCircle() { }
        public ThreeDCircle(string name)
            : base(name) { }


        public new void Draw()
        {
            Console.WriteLine("Drawing {0} the 3dCircle", empName);
        }

        public void Draw3D()
        {
            Console.WriteLine("Draw Circle in 3D!");
        }

    }
}