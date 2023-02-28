using System;

namespace HelloMars
{
    class Program
    {
        static void Main(string[]args)
        {
            string myName = args[0];
            Console.WriteLine("Hello Mars! from " + myName);
            Console.ReadLine();
        }
    }   
}