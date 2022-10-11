using System;
using System.Threading;

namespace WorkWithPool
{
    class Program
    {
        static void Task1(Object state)
        {
            Thread.CurrentThread.Name = "1";
            Console.WriteLine("Поток {0}:{1}", Thread.CurrentThread.Name,
            Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine();
            Thread.Sleep(200);
        }
        static void Task2(Object state)
        {
            Thread.CurrentThread.Name = "2";
            Console.WriteLine("Поток {0}:{1}", Thread.CurrentThread.Name,
            Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(200);
        }
        
        static void ShowThreadInfo()
        {
            int worker;
            int io;
            ThreadPool.GetAvailableThreads(out worker, out io);
            Console.WriteLine("Количество доступных рабочих потоков в пуле: \t{0}", worker);
            ThreadPool.GetMaxThreads(out worker, out io);
            Console.WriteLine("Количество доступных потоков ввода - вывода в пуле: {0}\n",io);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы программы");
            ShowThreadInfo();
            Console.WriteLine("Запускаем Task1 в потоке из пула потоков");
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));
            ShowThreadInfo();
            Console.WriteLine("Запускаем Task2 в потоке из пула потоков");
            Thread.Sleep(1000);
            ThreadPool.QueueUserWorkItem(Task2);
            ShowThreadInfo();
            Console.WriteLine("Главный поток.");

            Thread.Sleep(1000);

            Console.WriteLine("Главный поток завершен.\n");
            Console.WriteLine("Task1 и Task2 закончили работу");

            ShowThreadInfo();

            Console.ReadKey();
        }
    }
}
