using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampleST179
{
    class Car
    {
        public string Name;
        public int Speed;

        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", Name, Speed);
        public void SpeedUp(int delta)
            => Speed += delta;
        //изменение стандартного класса
        public Car()
        {
            Name = "Honda";
            Speed = 1;
        }
        //
        //Свой конструктор
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
        //
        //C#7 сжатый конструктор
        public Car(string name) => Name = name;
        //

    }
}
