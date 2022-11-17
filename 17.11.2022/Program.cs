using System.Reflection.Metadata.Ecma335;

namespace _17._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the limit number : ");
            int LimitNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Sum of the even numbers till {LimitNumber} is {SumEvenNumber(LimitNumber)}"  );
            SumEvenNumber1(LimitNumber);
        }

        static int SumEvenNumber(int n)
        {
            int sum = 0;
            for(int i=2; i<n; i+=2)
            {
                sum += i;
            }
            return sum;
        }
        static void SumEvenNumber1(int n)
        {
            int sum = 0;
            for (int i = 2; i < n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($" Sum of the even numbers till {n} is {sum}");
        }
    }
}