using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampleST179
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //Конструктор по умолчанию
           
            myCar.Name = "Mitsubishi"; //меняем публичные переменные
            myCar.Speed = 10;
            for(int i = 0; i<=10; i++)
            {
                myCar.SpeedUp(5); 
                myCar.PrintState();
            }

            Car SecondCar = new Car(); //Измененный стандартный конструктор

            SecondCar.PrintState();

            //Свой конструктор класса
            Car ThirdCar = new Car("Mazda", 30);
            ThirdCar.PrintState();
            ThirdCar.SpeedUp(5);
            ThirdCar.PrintState();

            Motoscycles FirstMoto = new Motoscycles("Harley");
            FirstMoto.PrintState();

            Motoscycles SecondMoto = new Motoscycles(7);
            SecondMoto.PrintState();

            Motoscycles ThirdMoto = new Motoscycles(30, "Honda");
            ThirdMoto.PrintState();

            Motoscycles.StaticPhunk();

            //ст 193
            SavingAccount FirstAcc = new SavingAccount(50);
            FirstAcc.PrintState();

            SavingAccount SecondAcc = new SavingAccount(100);
            SavingAccount.SetInterestRate(0.03);
            SecondAcc.PrintState();

            SavingAccount ThirdAcc = new SavingAccount(1000.33);
            ThirdAcc.PrintState();
            //

            StaticClass.PrintTime();
            StaticClass.PritDate();

            int[] kek = { 3, 2, 1, 4, 5, 6 };

            
            Array.Sort(kek);

            RocketLowncher Bazooka = new RocketLowncher();
            Bazooka.Shoot();
            ShootGun Rm = new ShootGun();
            Rm.Shoot();
            Gun Pistol = new Gun();
            Pistol.ammo = 30;
            Console.WriteLine("Ammo in pistol: {0}", Pistol.ammo);
            Pistol.Shoot();
            Pistol.ammo--;
            Console.WriteLine("Ammo in pistol: {0}", Pistol.ammo);

            Console.ReadLine();
        }
    }
}
