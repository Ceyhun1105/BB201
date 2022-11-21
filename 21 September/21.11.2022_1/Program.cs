namespace _21._11._2022_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 34, 45, 5, 6 };
            Resize(ref Array, 3);
            foreach (int i in Array)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine(Array.Length);    

           

        }
        static void Resize(ref int[] arr, int size)
        {
            int[] NewArr = new int[size];
            
                for (int i = 0; i < Math.Min(arr.Length,size); i++)
                {
                    NewArr[i] = arr[i];
                }
            arr = NewArr;
        }
    }
    }
