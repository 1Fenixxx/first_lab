using System;

namespace firstLab
{
    class Program
    {
        static int Main(string[] args)
        {
            foreach( string str in args)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Hello World, i think");

            Console.ReadKey();

            return 0;
        }
    }
}
