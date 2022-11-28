using Extentions;
namespace Extentions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "ananas1";
            Console.WriteLine(" how many an in ananas1? : "+name.MatchCount("an"));
            Console.WriteLine(" ananas1 has any digit? : "+name.HasAnyDigit());
            name = "ananas";
            Console.WriteLine(" how many a in ananas1? : " + name.MatchCount("a"));
            Console.WriteLine(" ananas has any digit? : " + name.HasAnyDigit());
            int number = 3553;
            Console.WriteLine(" First Step 3553 Polindromdur ? : "+number.Polindrom());
            number = 3555;
            Console.WriteLine(" Second Step 3555 Polindromdur ? : " + number.Polindrom());
        }
    }
}