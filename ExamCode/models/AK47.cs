using ExamCode.Interfaces;


namespace ExamCode.models
{
    internal class AK47 : Weapon, IWeapon , IShootAndFire
    {
       /* public AK47(int bulletcapacity , int bulletcount)
        {
           
            BulletCount = bulletcount;
            BulletCapacity = bulletcapacity;
        }*/

        public bool IsAuto { get ; set ; } = true;

        public void ChangeFireMode()
        {
            if(IsAuto) IsAuto = false;
            else IsAuto = true;
            Console.WriteLine("\n Mode changed...\n");
        }

        public void Fire()
        {
            if (BulletCount > 0)
            {
                if (IsAuto) BulletCount = 0;
                else BulletCount--;
                Console.WriteLine("\n Fired .....\n");
            }
            else Console.WriteLine(" Not Enaught Bullet ");
        }

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
            return $" Bullet Capacity : {BulletCapacity} Bullet Count : {BulletCount} Fire Mode (auto) :{IsAuto}";
        }
    }
}
