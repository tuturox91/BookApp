using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("Franklin", 90);

            MyCar.Accelerate(1000);

            //try
            //{
            //    MyCar.Accelerate(20);
            //}
            //catch (CarIsDeadExeption e)
            //    when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            //{
            //    Console.WriteLine("Car is dead");
            //    Console.WriteLine(e.Message);
            //    //throw;
            //}
            //catch (ArgumentOutOfRangeException e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    MyCar.CrankTunes(false);
            //}

            Console.ReadLine();
        }
    }
}
