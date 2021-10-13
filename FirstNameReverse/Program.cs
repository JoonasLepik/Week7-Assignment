using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter your firstname:");
            string firstname = Console.ReadLine();           
            if (firstname.Length > 5)
            {
                for (int i = firstname.Length - 1; i >= 0; i--)
                {
                    Console.Write(firstname[i]);
                }
            }
            else
            {
                Console.Write(firstname);
            }
        }
    }
}
