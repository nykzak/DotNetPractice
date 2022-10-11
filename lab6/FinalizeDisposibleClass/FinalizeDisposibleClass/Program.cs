using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeDisposibleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Dispose() / Destructor Combo Platter* ****");

            var rw = new Wrapper();
            Console.WriteLine(rw);
            Console.WriteLine(new string('-', 20));
            rw.Dispose();
            rw.Dispose();
            rw.Dispose();
            rw.Dispose();
            Wrapper rw2 = new Wrapper();
            Console.ReadLine();
        }
    }
}
