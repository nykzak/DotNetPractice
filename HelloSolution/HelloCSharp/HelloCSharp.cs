using System;
namespace HelloCSharp
{
    class HelloCSharp
    {
        static void Main()
        {
            HelloVB.HelloVB hello = new HelloVB.HelloVB();
            hello.Hello();
            Console.WriteLine("Привет из C#");
            Console.ReadLine();
        }
    }
}