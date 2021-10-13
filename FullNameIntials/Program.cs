using System;

namespace FullNameIntials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine($"Greetings {firstname[0]}. {lastname[0]}.");
        }
    }
}
