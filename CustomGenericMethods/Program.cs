using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            double xD = 0.34;
            double yD = 3.33;
            Console.WriteLine("Now X: {0} and Y: {1}", x, y);
            Swap(ref x,ref y);
            Console.WriteLine("After change X: {0} and Y: {1}", x, y);

            Console.WriteLine("Now X: {0} and Y: {1}", xD, yD);
            Swap(ref xD, ref yD);
            Console.WriteLine("After change X: {0} and Y: {1}", xD, yD);

            Person fP = new Person("Igor", "Bukur", 22);
            Person sp = new Person("Vlad", "Musica", 19);

            Swap(ref fP, ref sp);

            Console.ReadLine();
        }

        static void Swap<T>(ref T x,ref  T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
