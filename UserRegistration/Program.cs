using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static string validateFunction(string pattern,string name)
        {
            Regex regex = new Regex(pattern);
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
                    Console.WriteLine("\n\n********\n\n Invalid " + name+ "\n\n********\n\n");
                }
            }
        }

        public static string validatePassword(string pattern, string name)
        {
            Regex regex = new Regex(pattern);
            while (true)
            {
                Console.Write("Enter " + name + " : ");
                string userName = Console.ReadLine();

                if (!regex.IsMatch(userName))
                {
                    Console.WriteLine("\n\n********\n\n" + name + " is valid..." + "\n\n********\n\n");
                    return userName;
                }
                else
                {
                    Console.WriteLine("\n\n********\n\n Invalid " + name + "\n\n********\n\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration form...");
            string pattern = @"^[A-Z][A-Za-z]{2,}$";
            String firstName = validateFunction(pattern,"First Name");
            String lastName = validateFunction(pattern,"Last Name");

            Console.WriteLine("\n\n********\n\nYour full name is : " + firstName + " " + lastName+ "\n\n********\n\n");

            pattern = @"^[a-z][a-z0-9]*([.-_+][a-z0-9]+)?@([a-z0-9]+[.]){1,2}[a-z]{2,}$";
            string email = validateFunction(pattern, "Email");
 
            pattern = @"^[0-9]{1,2}\s[6-9][0-9]{9}$";
            string phoneNo = validateFunction(pattern, "Mobile Number");
     
            pattern = "^(([A-Z]+)|([0-9]+)|([a-z]+)|([A-Za-z0-9]+)|(.{0,7}))$";
            string password = validatePassword(pattern, "Password");

        }
    }
}
