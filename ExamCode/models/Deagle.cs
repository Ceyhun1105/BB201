using ExamCode.Interfaces;
namespace ExamCode.models
{
    internal class Deagle : Weapon, IShoot
    {
       /* public Deagle(int bulletcapacity, int bulletcount)
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
