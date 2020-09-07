using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        public static void GetName(Shape shape)
            =>Console.WriteLine("Shape name: {0}", shape.empName);

        static void Main(string[] args)
        {
            Circle fc = new Circle("FirstCircle");
            Hexagon fh = new Hexagon("FirstHexagon");
            ThreeDCircle ThreeDCircle = new ThreeDCircle("3d Circle");

            object[] ArrC = new  object[5];

            object sc = new Circle("SecondCircle");



            ArrC[0] = fc;
            ArrC[1] = fh;
            ArrC[2] = ThreeDCircle;
            ArrC[3] = (Circle)sc;
            ArrC[4] = new ClassDontForThisProject();


            Console.WriteLine(fc.ToString());
            

            foreach (object s in ArrC)
            {
                if (s is Shape d)
                {
                    d.Draw();
                }
                else
                {
                    ClassDontForThisProject h = s as ClassDontForThisProject;
                    if (h == null)
                    {
                        Console.WriteLine("Не ClassDontForThisProject");

                    }
                    else
                    {
                        h.Learn();
                    }
                }
                
            }

            GetName((Circle)ArrC[0]);
               

            

            Console.ReadLine();
        }
        
    }
}
