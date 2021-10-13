using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pin: 1532
            //Kasutajanimi: user1
            //Parool:password
            Console.WriteLine("Please enter your PIN-code");
            int PIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string Pasword = Console.ReadLine();
            if (username != "user1" || Pasword != "password1" && PIN == 1532)
            {
                Console.WriteLine("Wrong password or user, Please try again.");
            }
            else if (username != "user1" || Pasword != "password1" || PIN != 1532)
            {
                Console.WriteLine("Wrong PIN please try again.");
            }
            else
            {
                Console.WriteLine("Hello User and Welcome!");
            }

        }
    }       
}
