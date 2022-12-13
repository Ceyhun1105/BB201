namespace ExamCode.models
{
    internal static class WeaponsList
    {
        public static List<Weapon> Weapons = new List<Weapon>();

        static void AddWeapon(Weapon weapon)
        {
            Weapons.Add(weapon);
        }
    }
}
