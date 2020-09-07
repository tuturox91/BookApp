using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    public abstract class Shape
    {
        public string empName { get; set; }

        public Shape(string name = "NoName")
            => empName = name;

        public abstract void Draw();
    }
}