using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static string validateFunction(Regex regex,string name)
        {
            while (true)
            {
                Console.Write("Enter "+name+" : ");
                string userName = Console.ReadLine();

                if (regex.IsMatch(userName))
                {
                    Console.WriteLine("\n\n********\n\n" + name+" is valid..." + "\n\n********\n\n");
                    return userName;
                }
                else
                {
                    Console.WriteLine("\n\n********\n\n Invalid " + name+ " ... Please enter atleast three characters starting with a Capital letter (Eg.: Sam,Jack)"+ "\n\n********\n\n");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration form...");

            string pattern = @"^[A-Z][A-Za-z]{2,}$";
            Regex regex = new Regex(pattern);

            String firstName = validateFunction(regex,"First Name");
            String lastName = validateFunction(regex,"Last Name");

            Console.WriteLine("\n\n********\n\nYour full name is : " + firstName + " " + lastName+ "\n\n********\n\n");

        }
    }
}
