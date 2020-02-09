using System;

namespace DipDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father("Book");
            father.Read();

            Console.ReadKey();
        }
    }
}
