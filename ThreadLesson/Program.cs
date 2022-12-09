namespace ThreadLesson
{
    internal class Program
    {


        static async Task Main(string[] args)

        {


            #region Asynccode

            /* Thread thread1 = new Thread(Plus);
             Thread thread2 = new Thread(Minus);

             thread1.Start();
             thread1.Join();
             thread2.Start();
             */
            #endregion


            #region Lockcode
            /* Program program = new Program(); 


             Thread thread1 = new Thread(program.Increase);
             Thread thread2 = new Thread(program.Decrease);
             thread2.Start();
             thread1.Start();
             thread2.Join();
             thread1.Join();
             Console.WriteLine(program.Count);*/
            #endregion

            #region DeadLockCode

            /*Program program = new Program();


            Thread thread1 = new Thread(program.Increase);
            Thread thread2 = new Thread(program.Decrease);
            thread2.Start();
            thread1.Start();
            thread2.Join();
            thread1.Join();
            Console.WriteLine(program.Count);*/
            #endregion

            /*var b= Task.Run(() =>
            {
                return "Hello World !";
            }).Result;

            Console.WriteLine(b);



            
            var c= Task.Run(() =>
            {
                return "Hello World !";
            });

            Console.WriteLine(c.Result);




            var a = Task.Run(() =>
            {
                return "Hello World !";
            });

            Console.WriteLine(a);*/

            /*Console.WriteLine(GetHtml());*/



            var a = await GetString();
            Console.WriteLine(a);
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

        #region Lock
        /* private object Lock1 = new object();
       public  int Count { get; set; }

       public void Increase()
       {
           for(int i=0;i<1000000;i++)
           {
               lock(Lock1)
               { 
                   Count++;    
               }
           }
       }
       public void Decrease()
       {
           for(int i=0;i<1000000;i++)
           {
               lock (Lock1)
               {
                   Count--;
               }
           }
       }*/

        #endregion

        #region DeadLock

        /*   private object Lock1 = new object();
           private object Lock2 = new object();
           public int Count { get; set; }

           public void Increase()
           {
               for (int i = 0; i < 1000000; i++)
               {
                   lock(Lock2) 
                   {
                            lock (Lock1)
                            {
                                Count++;
                            }
                   }
               }
           }
           public void Decrease()
           {
               for (int i = 0; i < 1000000; i++)
               {
                   lock (Lock1)
                   {
                       lock (Lock2)
                       {
                           Count--;
                       }
                   }
               }
           }*/
        #endregion


        public static string GetHtml()
        {
            HttpClient httpClient = new HttpClient();
            return httpClient.GetStringAsync("https://github.com").Result;
        } 
        public static Task<string> GetString()
        {
            HttpClient httpClient = new HttpClient();
            return httpClient.GetStringAsync("https://github.com");
        }

    }
}