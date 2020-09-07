using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon oct = new Octagon();
            IDrawToForm octF = (IDrawToForm)oct;
            octF.Draw();

            IDrawToMemory octM = (IDrawToMemory)octF;
            octM.Draw();

            IDrawToPrinter octP = (IDrawToPrinter)octF;
            octM.Draw();

            Console.ReadLine();

        }
    }
}
