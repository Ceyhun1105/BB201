using ExamCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode.models
{
    internal class AWP : Weapon, IShoot
    {

       /* public AWP(int bulletcapacity, int bulletcount)
        {
            BulletCount = bulletcount;
            BulletCapacity = bulletcapacity;
        }*/


        public void Shoot()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                Console.WriteLine("\n Shooted .....\n");
            }
            else Console.WriteLine(" Not Enaught Bullet ");
        }

        public override string ToString()
        {
            return $" Bullet Capacity : {BulletCapacity} Bullet Count : {BulletCount} ";
        }
    }
}
