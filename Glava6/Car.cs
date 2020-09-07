using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava6
{
    abstract partial class Car
    {
        public readonly int maxSpeed;
        public int valueOfCircles;
        private int currSpeed;
        protected ZavestiCar ZavodCar = new ZavestiCar();

        public bool GetZavod()
            => ZavodCar.GetStart();

        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car(int max, int ValueOfCircles)
            : this(max)
        {
            valueOfCircles = ValueOfCircles;
        }
        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed
        {
            get { return currSpeed; }
            set {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }

    class ZavestiCar 
    {
        public bool GetStart()
            => true;
    }

    class MiniVan : Car
    {
        public bool HavePricep;

        public MiniVan() { }
        public MiniVan(int max, bool havePricep)
            : base(max)
        {
            HavePricep = havePricep;
        } 
    }
}
