using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Fred", 40, 234);
            myAutos[2] = new Car("Vlad", 40, 34);
            myAutos[3] = new Car("Anton", 40, 4);
            myAutos[4] = new Car("Chuk", 40, 5);
            for(int i = 0; i<myAutos.Length; i++)
                Console.WriteLine("Id: {0} Name: {1}, Speed: {2}", myAutos[i].CarID, myAutos[i].PetName, myAutos[i].CurrentSpeed);

            Console.WriteLine("");

            Array.Sort(myAutos);
            for (int i = 0; i < myAutos.Length; i++)
                Console.WriteLine("Id: {0} Name: {1}, Speed: {2}", myAutos[i].CarID, myAutos[i].PetName, myAutos[i].CurrentSpeed);


            Console.WriteLine("");
            Array.Sort(myAutos, new NameComparer());
            for (int i = 0; i < myAutos.Length; i++)
                Console.WriteLine("Id: {0} Name: {1}, Speed: {2}", myAutos[i].CarID, myAutos[i].PetName, myAutos[i].CurrentSpeed);


            Console.ReadLine();
        }
    }
}
