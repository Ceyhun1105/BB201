using ExamCode.models;

namespace ExamCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon ak47 = new AK47();
            Weapon uzi = new UZI();
            Weapon awp = new AWP();
            Weapon deagle = new Deagle();

            WeaponsList.Weapons.Add(ak47);
            WeaponsList.Weapons.Add(uzi);
            WeaponsList.Weapons.Add(awp);
            WeaponsList.Weapons.Add(deagle);
            AppChoice.ChooseApp();

        }
    }
}