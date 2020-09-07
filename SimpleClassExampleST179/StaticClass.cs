using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampleST179
{
    static class StaticClass
    {
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now.ToShortTimeString());
        public static void PritDate()
            => Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}
