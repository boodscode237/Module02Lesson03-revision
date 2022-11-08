using System;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string firstName;
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            string lastName = Console.ReadLine();
/*
            if (firstName != null && firstName.ToLower() == "john")
            {
                Console.WriteLine($"Welcome {firstName} {lastName}");
            }
            else if (firstName != null && firstName.ToLower() == "doe")
            {
                Console.WriteLine($"Welcome {firstName} {lastName}");
            }
            else
            {
                if (firstName != null) Console.WriteLine($"Sorry {firstName.ToUpper()} not found");
            }
            
*/
            if (lastName != null 
                && firstName != null 
                && (firstName.ToLower() == "john" 
                    && lastName.ToLower() == "doe" 
                    || firstName.ToLower() == "elon"
                    && lastName.ToLower() == "musk"))
            {
                Console.WriteLine($"Hello {firstName} {lastName}");
            }
            else
            {
                Console.WriteLine($"Not in DB Mr {lastName} {firstName}");
            }

            switch (firstName?.ToLower())
            {
                case "elon":
                    Console.WriteLine("Hello Expert");
                    break;
                case "john":
                    Console.WriteLine("Hello Prof");
                    break;
                default:
                    Console.WriteLine("Hello student");
                    break;
            }
            Console.WriteLine("All done");
            Console.ReadLine();
        }
    }
}