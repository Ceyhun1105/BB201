namespace ThreadLesson
{
    internal class Program
    {
        static void Main(string[] args)

        {


            #region Asynccode

            /* Thread thread1 = new Thread(Plus);
             Thread thread2 = new Thread(Minus);

             thread1.Start();
             thread1.Join();
             thread2.Start();
             */
            #endregion


            Thread thread1 = new Thread(Increase);
            Thread thread2 = new Thread(Decrease);
            thread2.Start();
            thread2.Join();
            thread1.Start();
            Console.WriteLine(count);

        }
        #region Async
        /* public static int Count { get; set; }

         public static void Plus()
         {
             for (int i = 0; i < 100; i++)
             {
                 Console.Write("+ ");
             }
         }
         public static void Minus()
         {
             for (int i = 0; i < 100; i++)
             {
                 Console.Write("- ");
             }
         }*/
        #endregion

        public static int count=0;

        static void Increase()
        {
            for(int i=0;i<1000000;i++)
            {
                    count++;    
            }
        }
        static void Decrease()
        {
            for(int i=0;i<1000000;i++)
            {
                    count-- ;    
            }
        }


    }
}