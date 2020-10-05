using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration form...");

            Console.Write("Enter user name : ");
            string userName = Console.ReadLine();
            string pattern = @"^[A-Z][A-Za-z0-9_]{2,}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(userName))
            {
                Console.WriteLine("Username is valid...");
            }
            else
            {
                Console.WriteLine("Invalid Username ... Please enter atleast three characters starting with a Capital letter (Eg.: Sam,Tom_1)");
            }

        }
    }
}
