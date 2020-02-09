using System;
namespace DipDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Book
            //var f = new Father(new Book());
            //f.Read();

            // Paprer
            var f = new Father(new Paper());
            f.Read();

            Console.ReadKey();
        }
    }
}
