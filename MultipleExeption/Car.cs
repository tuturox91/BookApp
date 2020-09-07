using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MultipleExeption
{
    class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurOn(state);
        }

       

        public void Accelerate(int delta)
        {

            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Скорость должна быть больше 0");


            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    //CarIsDeadExeption ex = new CarIsDeadExeption("Current speed > MaxSpeed");

                    CarIsDeadExeption ex = new CarIsDeadExeption($"{PetName} перегрет. ", "Превысили", DateTime.Now);


                    //Exception ex = new Exception($"Error 1, {PetName} превысил максимальную скорость!");
                    ex.HelpLink = "https://vk.com/decurion";
                    //ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    //ex.Data.Add("Cause", "You have a lead foot");

                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);

            }
        }
    }
}
