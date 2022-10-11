using System;
using System.Threading;

namespace Simple_Thread
{
    class Program
    {
        public static void Function()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
        }
       
  static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Function));
            thread.Start();
            thread.Join();
            for (int u = 1; u <= 100; u++)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(u);
            }
            Console.Read();
        }
    }
}
