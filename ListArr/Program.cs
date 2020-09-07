using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists keks = new Lists(3);
            Lists keks2 = new Lists(4,ref keks);
            Lists keks3 = new Lists(9, ref keks2);



            Console.ReadLine();
        }
    }
}
