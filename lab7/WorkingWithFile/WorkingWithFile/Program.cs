using System;
using System.IO;
using System.Threading;

namespace WorkingWithFile
{
 
    class Program
    {
       public const string FILE_NAME = "RandNumbers.data";
        private static ManualResetEvent mre = new ManualResetEvent(false);

        public static void ThreadWCF()
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);
            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
                {
                    w.Write(rnd.Next(0, 101));
                }
           fs.Close();
        }

          public static void ThreadWRF()
           {
             mre.WaitOne();
             FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
               BinaryReader r = new BinaryReader(fs);

               Console.WriteLine($"Случайные числа:");

               for (int i = 1; i <= 100; i++)
                   {
                    Console.WriteLine(r.ReadInt32());
                   }
               fs.Close();

           }  

           public static void ThreadWSN()
           {
            mre.WaitOne();
               using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read))
               {
                   using (BinaryReader rs = new BinaryReader(fs))
                   {
                       Console.WriteLine($"Сумма случайных чисел:");
                       int sumOfNumber = 0;
                       for (int i = 1; i <= 100; i++)
                       {
                           sumOfNumber += rs.ReadInt32();
                       }
                       Console.WriteLine(sumOfNumber);
                   }
               }
           } 


        public static void Main()
        {
           

            Thread threadWCF = new Thread(new ThreadStart(ThreadWCF));
            threadWCF.Start();


            Console.WriteLine("\nЗапись прошла успешна , нажмите Enter\n");

            Console.ReadLine();
            mre.Reset();

            Thread.Sleep(500);
            mre.Set();
            Thread threadWRF = new Thread(new ThreadStart(ThreadWRF));
            threadWRF.Start();
        


            Thread.Sleep(700);
            Thread threadWSN = new Thread(new ThreadStart(ThreadWSN));
            threadWSN.Start();

           

            Console.Read();
        }
    }
}
