using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstBookApp
{
    public class SportCar : Car
    {
        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}