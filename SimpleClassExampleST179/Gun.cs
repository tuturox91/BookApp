using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampleST179
{
    class Gun
    {
        public string Name { get; set; }
        private int  empAmmo;

        public int ammo
        {
            get => empAmmo;
            set
            {
                if (value > 30)
                {
                    Console.WriteLine("в обойме не может быть больше 30 патронов");
                }
                else
                {
                    empAmmo = value;
                }
            }
        }
        
       public virtual void Shoot()
        {
            
            Console.WriteLine("I shoot from {0}: PEW! PEW!", "Gun");
            
        } 
    }


    class RocketLowncher : Gun 
    {
        
        public override void Shoot()
        {
            Console.WriteLine("I shoot from rocket-louncher: BOM! BOM!");
        }

    }

    class ShootGun : Gun
    {
        public override void Shoot()
        {
            Console.WriteLine("I shoot from shootgun: Bams! Bams!");
        }
    }
}
