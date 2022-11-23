using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponeClass
{
    internal class Weapone
    {
        public Weapone(int bulletcapacity, int bulletcount, double dischargetime, bool auto)
        {
            this.BulletCapacity = bulletcapacity;
            this.BulletCount = bulletcount;
            this.Dischargetime = dischargetime;
            this.IsAuto = auto;
        }


        private int _bulletcapacity;
        private int _bulletcount;
        private double _dischargetime;

        public bool IsAuto;
        public int BulletCapacity
        {
            get { return _bulletcapacity; }
            set
            {
                if (value > 3 && value < 180)
                {
                    _bulletcapacity = value;
                }
            }
        }
        public int BulletCount
        {
            get { return _bulletcount; }
            set
            {
                if (value < BulletCapacity && value > 0)
                {
                    _bulletcount = value;
                }
            }
        }

        public double Dischargetime
        {
            get { return _dischargetime; }
            set
            {
                if (value > 2 && value < 10)
                {
                    _dischargetime = value;
                }
            }
        }

        public void WeaponeInfo()
        {
            Console.WriteLine($"\n capacity : {BulletCapacity}\n bulletcount : {BulletCount}\n discharger time : {Dischargetime}\n AutoMode : {IsAuto}");
        }

        public void Shoot()
        {
            if (BulletCount > 0)
            {
                Console.WriteLine("\n Shooted 1 bullet ");
                BulletCount--;
                Console.WriteLine($" Weapone has {BulletCount} bullet");
            }
            else
            {
                Console.WriteLine("\n Weapone do not have any bullet\n You can use Reload ");
            }
        }

        public void Fire()
        {
            if (IsAuto == true)
            {
                if (BulletCount != 0)
                {
                    double time = Dischargetime / BulletCapacity * BulletCount;

                    _bulletcount = 0;
                    Console.WriteLine(" Fired all bullet ..");


                    Console.WriteLine($" Bullets shooted for {time} second ");
                }
                else
                {
                    Console.WriteLine("\n Weapone do not have any bullet\n You can use Reload ");
                }
            }
            else
            {
                Console.WriteLine("\n Can not All bullet in Single Mode Fire ... ");
                Shoot();
            }
        }

        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletCount;
        }

        public void Reload()
        {
            if (BulletCount != BulletCapacity)
            {
                //BulletCount=BulletCapacity;
                _bulletcount += GetRemainBulletCount();
                Console.WriteLine($" Reload weapone . You have {BulletCapacity} bullet");
            }
            else
            {
                Console.WriteLine("\n Capacity is Full .. You can Fire or Shoot...");
            }
        }

        public void ChangeFireMode()
        {
            if (IsAuto == true)
            {
                IsAuto = false;
                Console.WriteLine(" Fired Mode Changed Single Mode..");
            }
            else
            {
                IsAuto = true;
                Console.WriteLine(" Fired Mode Changed Auto Mode..");
            }
        }



    }
}
