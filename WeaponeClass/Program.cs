using WeaponeClass;

internal class Program
{
    static void Main(string[] args)
    {
        int BulletCapacity;
        int BulletCount;
        double Dischargertime;
        bool IsAuto;
        bool check;
        do
        {
            Console.Write(" Enter BulletCapacity : ");
            check = int.TryParse(Console.ReadLine(), out BulletCapacity);
        } while (!check);

        do
        {
            Console.Write(" Enter BulletCount : ");
            check = int.TryParse(Console.ReadLine(), out BulletCount);
        } while (!check);

        do
        {
            Console.Write(" Enter Discharge time : ");
            check = double.TryParse(Console.ReadLine(), out Dischargertime);
        } while (!check);

        do
        {
            Console.Write(" Enter the Mod ( default Auto ) : ");
            check = bool.TryParse(Console.ReadLine(), out IsAuto);
        } while (!check);


        Weapone weapon1 = new Weapone(BulletCapacity, BulletCount, Dischargertime, IsAuto);
        
        string choice;
        do
        {
            Console.WriteLine("\n 0 - See Weapone Information\n" +
                " 1 - Bring Shoot Method\n" +
                " 2 - Bring Fire Method\n" +
                " 3 - return you need number of bullet for full capacity\n" +
                " 4 - Reload\n" +
                " 5 - Change Fire Mode\n" +
                " 6 - Close App");
            Console.Write("\n Enter your Choice : ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    weapon1.WeaponeInfo();
                    break;
                case "1":
                    weapon1.Shoot();
                    break;
                case "2":
                    weapon1.Fire();
                    break;
                case "3":
                    Console.WriteLine($" You need {weapon1.GetRemainBulletCount()} bullet for full capacity");
                    break;
                case "4":
                    weapon1.Reload();
                    break;
                case "5":
                    weapon1.ChangeFireMode();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine(" Our Service has not your choice ");
                    break;
            }
        } while (choice!="6");



    }
}