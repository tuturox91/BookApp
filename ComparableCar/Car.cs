using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ComparableCar 
{
    class Car : IComparable
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        public int CarID { get; set; }



        public Car() { }

        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                if (this.CarID > temp.CarID)
                    return 1;
                if (this.CarID < temp.CarID)
                    return -1;
                else
                    return 0;
            }
            else
                throw new Exception("Error");
        }
        
    }
}
