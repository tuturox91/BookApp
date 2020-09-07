﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Fred", 90);
            try
            {
                myCar.Accelerate(50);
            }
            catch (CarIsDeadExeption e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
