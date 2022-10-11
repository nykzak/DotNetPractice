using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarLibrary;
namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** c# CarLibrary Client App *****");
            // Создать объект спортивного автомобиля.
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();
            // Создать объект минивэна.
            MiniVan mv = new MiniVan();
            mv.TurboBoost();
            Console.WriteLine("Done. Press any key to terminate");
            Console.ReadLine();
        }
    }
}