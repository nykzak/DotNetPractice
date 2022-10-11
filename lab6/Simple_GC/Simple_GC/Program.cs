using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_GC
{
    class Program
    {
        class Test
        {
            int[] arr = new int[1000000];
            public void Method(int i)
            {
                Console.WriteLine(i);
            }
            ~Test()
            {
                Console.WriteLine("Object " + this.GetHashCode() + "deleted");
            }
        }
        static void Main(string[] args)
        {
            var tests = new Test[1000000];
            try
            {
                for (int i = 0; i < tests.Length; i++)
                {
                    tests[i] = new Test();
                    tests[i].Method(i);
                    //Test test = new Test();
                    //test.Method(i);
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine("Управляемая куча переполнена");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadLine();

        }
    }
}
