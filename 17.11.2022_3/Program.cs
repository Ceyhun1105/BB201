namespace _17._11._2022_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the string value : ");
            string str1 = Console.ReadLine();

            FirstLetter(str1);
        }
        static void FirstLetter(string str)
        {
            str = str.Trim();
            Console.Write(str[0] + " ");
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    char newletter = (str[i + 1]);
                    Console.Write(newletter + " ");
                }
            }
        }
    }
}