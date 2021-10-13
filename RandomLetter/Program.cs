using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your firstname:");
            string firstname = Console.ReadLine();
            Random rnd = new Random();
            int rndletter = rnd.Next(0, firstname.Length);
            Console.WriteLine(firstname[rndletter]);
        }
    }
}
