using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampleST179
{
    class Motoscycles
    {
        
        public int Intensity;
        public string Name;
        public Motoscycles() { }
        //ст. 188
        public Motoscycles(int intensity)
            : this(intensity, "NoName")
        {
            Console.WriteLine("Tested the constructor");
        }
        public Motoscycles(string name)
            : this(1, name) { }
        public Motoscycles(int intensity, string name)
        {
            if(intensity > 10)
            {
                intensity = 10;
            }
            Intensity = intensity;
            Name = name;
        }

        public static void StaticPhunk()
        {
            Console.WriteLine("Это можно вызвать просто из Motosycles");
        }

        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", Name, Intensity);
    }
}
