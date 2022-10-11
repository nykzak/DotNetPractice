using System;
using System.Threading;

namespace MutexWorkl
{
    class Program
    {
        
        private static Mutex mut = new Mutex();
        private const int numIterations = 1;
        private const int numThreads = 3;

        static void Main()
        {
            Program ex = new Program();
            ex.StartThreads();
            Console.Read();
        }

        private void StartThreads()
        {
          
            for (int i = 0; i < numThreads; i++)
            {
                Thread newThread = new Thread(new ThreadStart(ThreadProc));
                newThread.Name = String.Format("Поток{0}", i + 1);
                newThread.Start();
            }

          
        }

        private static void ThreadProc()
        {
            for (int i = 0; i < numIterations; i++)
            {
                UseResource();
            }
        }

    
        private static void UseResource()
        {

            Console.WriteLine("{0} запрашивает mutex", Thread.CurrentThread.Name);
            if (mut.WaitOne(1000))
            {
                //симуляция работы
                Console.WriteLine("{0} вошел в защиту ",
                    Thread.CurrentThread.Name);

               
                Thread.Sleep(5000);

                Console.WriteLine("{0} вышел с защиты",
                    Thread.CurrentThread.Name);

         
                mut.ReleaseMutex();
                Console.WriteLine("{0} выпуск mutex",
                                  Thread.CurrentThread.Name);
            }
            else
            {
                Console.WriteLine("{0} не приобретет mutex",
                                  Thread.CurrentThread.Name);
            }
        }

        ~Program()
        {
            mut.Dispose();
        }
    }
}

