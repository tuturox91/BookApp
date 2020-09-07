using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nueron
{
    class Program
    {
        static void Main(string[] args)
        {
            nueron f1 = new nueron();
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Iteration: {0} Вес: {1}", i, f1.x);
            }
            while (f1.Train(70m) == -1) ;
            //Console.WriteLine("Iteration: {0} Вес: {1}", i, f1.x);

            Console.ReadLine();
        }

        
    }
}
