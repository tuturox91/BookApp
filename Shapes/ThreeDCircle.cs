using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class ThreeDCircle : Circle
    {
        public ThreeDCircle() { }
        public ThreeDCircle(string name)
            : base(name) { }


        public new void Draw()
        {
            Console.WriteLine("Drawing {0} the 3dCircle", empName);
        }

       
    }
}