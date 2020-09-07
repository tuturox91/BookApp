using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification: ");
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            p4.desc.PetName = "My new point";
            p4.X = 9;

            Console.WriteLine("Affter: ");
            Console.WriteLine(p3);
            Console.WriteLine(p4);



            Console.ReadLine();

        }
    }
}
