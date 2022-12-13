
namespace ExamCode.models
{
    internal static class ChooseWeapon
    {
        public static int Choose()
        {

        Choose:
            Console.Write("\n 1-AK-47\n 2-UZI\n 3-AWP\n 4-Deagle\n Enter your Choice : ");
            string choice = Console.ReadLine();
            int result = 0;
            switch (choice)
            {
                case "1":
                    result = 0;
                    break;
                case "2":
                    result = 1;
                    break;
                case "3":
                    result = 2;
                    break;
                case "4":
                    result = 3;
                    break;
                default:
                    goto Choose;
            }
            return result;

        }
    }
}
