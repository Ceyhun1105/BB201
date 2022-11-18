
namespace _18._11._2022_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1];
            numbers[0] = 1;
            bool ContinueStep = true;
            bool Stop = false;
            do
            {
                if (ContinueStep == false)
                {
                    Console.Write("\n Do you want to comtinue? Answer : ");
                    string answer = Console.ReadLine();
                    if (answer == "yes" | answer == "Yes")
                    {
                        string value = string.Empty;
                        string newvalue = EnterNum(value);
                        ResizeArray(ref numbers, newvalue);


                    }
                    else
                    {
                        Stop = true;
                    }
                }
                else
                {
                    string value = string.Empty;
                    string newvalue = EnterNum(value);
                    ResizeArray(ref numbers, newvalue);

                }




                ContinueStep = false;

                Console.WriteLine();




            } while (Stop == false);

        }
        static string EnterNum(string str1)
        {
            Console.Write(" Enter the number : ");
            str1 = Console.ReadLine();
            return str1;
        }
        static bool IsNumber(string str1)
        {
            bool IsTrue = Int32.TryParse(str1, out int n);
            return IsTrue;
        }
        static void ResizeArray(ref int[] arr, string str1)
        {

            if (IsNumber(str1) == true)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = Convert.ToInt32(str1);
                Console.WriteLine($" Change your Array`s Length : {arr.Length}\n");
                Console.WriteLine(" Array is changed... \n");
                foreach (int num in arr)
                {
                    Console.Write(" " + num);
                }
            }
            else
            {
                Console.WriteLine("\n Array doesn`t change");
            }
        }

    }
}