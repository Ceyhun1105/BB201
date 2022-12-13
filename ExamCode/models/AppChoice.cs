namespace ExamCode.models
{
    internal static class AppChoice
    {
        public static void ChooseApp()
        {
            bool continuee = true;
            int yourch = ChooseWeapon.Choose();


            Console.Write(" BulletCapacity : ");
            int count1 = int.Parse(Console.ReadLine());
            WeaponsList.Weapons[yourch].BulletCapacity = count1;
            int count2 = 0;
            do
            {
                Console.Write(" BulletCount : ");
                count2 = int.Parse(Console.ReadLine());
            } while (count2>count1);
            WeaponsList.Weapons[yourch].BulletCount = count2;

            do { 
            Console.Write("\n\n0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Edit :\r\n7 - Proqramdan dayandırmaq üçün qısayoldur.\n Enter your Choice : ");
            string choice = Console.ReadLine();
                switch (choice)
                {

                    case "0":
                        Console.WriteLine("\n"+WeaponsList.Weapons[yourch]);
                        break;
                    case "1":
                        if (yourch == 0) ((AK47)WeaponsList.Weapons[yourch]).Shoot();
                        if (yourch == 1) ((UZI)WeaponsList.Weapons[yourch]).Shoot();
                        if (yourch == 2) ((AWP)WeaponsList.Weapons[yourch]).Shoot();
                        if (yourch == 3) ((Deagle)WeaponsList.Weapons[yourch]).Shoot();
                        
                        break;
                    case "2":
                        if (yourch == 0) ((AK47)WeaponsList.Weapons[yourch]).Fire();
                        if (yourch == 1) ((UZI)WeaponsList.Weapons[yourch]).Fire();
                        if (yourch == 2) Console.WriteLine(" This weapon is not support Fire method");
                        if (yourch == 3) Console.WriteLine(" This weapon is not support Fire method");
                        break;
                    case "3":
                        Console.WriteLine($" Need {WeaponsList.Weapons[yourch].GetRemainBulletCount()} Bullet for Full Capacity");
                        break;
                    case "4":
                        WeaponsList.Weapons[yourch].Reload();
                        break;
                    case "5":
                        if (yourch == 0) ((AK47)WeaponsList.Weapons[yourch]).ChangeFireMode();
                        if (yourch == 1) Console.WriteLine(" This weapon is not support ChangeMode method");
                        if (yourch == 2) Console.WriteLine(" This weapon is not support ChangeMode method");
                        if (yourch == 3) Console.WriteLine(" This weapon is not support ChangeMode method");
                        break;
                    case "6":
                        Console.Write("\n\n 1- Tutumu deyis\n 2- gulle sayini deyis\n 3- Change Weapon\n Your Choice :  ");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "1":
                                Console.Write("Enter count of capacity : ");
                                int countcapacity = Convert.ToInt32(Console.ReadLine());
                                if (countcapacity < WeaponsList.Weapons[yourch].BulletCount)
                                {
                                    WeaponsList.Weapons[yourch].BulletCount = countcapacity;
                                    WeaponsList.Weapons[yourch].BulletCapacity=countcapacity;
                                }
                                else WeaponsList.Weapons[yourch].BulletCapacity = countcapacity;
                                break;
                            case "2":
                                Console.Write("Enter count of bullet : ");
                                int countbullet = Convert.ToInt32(Console.ReadLine());
                                if (WeaponsList.Weapons[yourch].BulletCapacity < countbullet) Console.WriteLine(" Out of Capacity");
                                else  WeaponsList.Weapons[yourch].BulletCount = countbullet;
                                break;
                            case "3":
                                yourch = ChooseWeapon.Choose();
                                Console.Write(" BulletCapacity : ");
                                int counttt1 = int.Parse(Console.ReadLine());
                                WeaponsList.Weapons[yourch].BulletCapacity = counttt1;
                                int counttt2;
                                do
                                {
                                    Console.Write(" BulletCount : ");
                                    counttt2 = int.Parse(Console.ReadLine());
                                } while (counttt2 > counttt1);
                                    WeaponsList.Weapons[yourch].BulletCount = counttt2;
                                break;
                        }
                        break;
                    case "7":
                        continuee = false;
                        break;
                }
                
             }while (continuee);

        }
    }
}
