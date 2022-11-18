namespace _11._18._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a=string.Empty;
            a=EnterValue(a);
            CheckValue(a,ref a);
            string b=string.Empty;
            b=EnterValue(b);
            CheckValue(b,ref b);
            int newA = Convert.ToInt32(a);
            int newB = Convert.ToInt32(b);
            Console.WriteLine();
            Console.WriteLine($"{a}+{b}={Sum(newA, newB)}");
        }


        static string EnterValue(string str)
        {
            Console.Write("Enter the Number : ");
            str = Console.ReadLine();
            return str;
        }
        static bool CanChangeInt(string str)
        {
            bool CanChangeInt = Int32.TryParse(str, out int value);
            return CanChangeInt;
        }
        static void CheckValue(string str, ref string str1)
        {
            bool check = true;
            do
            {
                if (CanChangeInt(str) == true)
                {
                    check = false;
                }
                else
                {
                    Console.Write("   Your String can not change to int !!!  ");
                    str = EnterValue(str);
                    str1 = str;
                }
            } while (check == true);
        }
        static int Sum(int num1,int num2)
            {
                return num1 + num2;
            }
    }
}