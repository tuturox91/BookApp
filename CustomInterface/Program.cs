using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle ft = new Triangle("FirstTriangle");
            ft.Draw();
            Console.WriteLine("Количество поинтов: {0}",ft.Points);
            Hexagon fh = new Hexagon("FirstHexagone");
            fh.Draw();
            Console.WriteLine("Количество поинтов: {0}", fh.Points);

            //Проверка поддерживает ли класс еще и нужный нам интерфейс
            //V0
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }


            //V1
            IPointy itfPt2 = c as IPointy;
            if (itfPt2 != null)
            {
                Console.WriteLine("Points: {0}", itfPt2.Points);
            }
            else
                Console.WriteLine("OOOOPS!");


            Shape[] myShapes = { new ThreeDCircle(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            for(int i =0; i<myShapes.Length; i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IDraw3d)
                    DrawIn3D((IDraw3d)myShapes[i]);
            }

            //


            IPointy firstItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The itam has {0} points", firstItem.Points);


            Console.ReadLine();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach(Shape s in shapes)
            {
                if (s is IPointy ip)
                    return ip;
            }
            return null;
        }

        static void DrawIn3D(IDraw3d itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

    }
}
