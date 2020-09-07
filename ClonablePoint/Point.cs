using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();


        public Point(int x, int y, string petName) 
        { 
            X = x; Y = y;
            desc.PetName = petName;
        }
        public Point(int x, int y ) { X = x; Y = y; }
        public Point() { }

        

        public override string ToString()
            => $"X={X}; Y={Y}; Name = {desc.PetName};\nID = {desc.PointID}";

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();

            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
