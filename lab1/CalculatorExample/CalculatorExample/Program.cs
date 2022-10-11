using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CalculatorExample
{
    class Program
    {
        // Калькулятор на С#.
        class Calc
        {
            public int Add(int x, int y) { return x + y; }
        }
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine("10 + 84 is {0}.", ans);
            // Ожидать нажатия пользователем клавиши <Enter> перед выходом.
            Console.ReadLine();
        }
    }
}