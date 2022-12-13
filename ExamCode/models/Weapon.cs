
namespace ExamCode.models
{
    internal class Weapon
    {
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }

        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletCount;
        }
        public void Reload()
        {
            if (BulletCapacity != BulletCount)
            {
                BulletCount = BulletCapacity;
                Console.WriteLine("\n reloading...\n");
                Thread.Sleep(500);
            }
            else Console.WriteLine(" Bullet Capacity is full");
        }
    }
}
