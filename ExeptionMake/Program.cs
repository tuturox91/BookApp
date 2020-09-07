using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExeptionMake
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Метод: {0}", e.TargetSite);
                Console.WriteLine("Класс определяющий член: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Тип чоена: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Сообщение: {0}", e.Message);
                Console.WriteLine("Источник: {0}", e.Source);
                Console.WriteLine("Стак: {0}", e.StackTrace);

                Console.WriteLine("Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0} : {1}", de.Key, de.Value);



               Console.WriteLine("Помощь тут: {0}", e.HelpLink);

            }




            Console.ReadLine();
        }
    }
}
