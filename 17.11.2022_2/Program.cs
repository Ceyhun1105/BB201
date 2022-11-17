namespace _17._11._2022_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the string value : ");
            string str1 = Console.ReadLine();

            Console.WriteLine($" After delete spaces \n Your String changed from {str1} to {DeleteSpaces(str1)} ");
            
        }

        static string DeleteSpaces (string str)
        {
            string StringWithDeleteSpaces = "";
            foreach(char s in str)
            {
                if(s!=' ')
                {
                    StringWithDeleteSpaces += s;
                }
            }
            return StringWithDeleteSpaces;
        }

       
    }
}