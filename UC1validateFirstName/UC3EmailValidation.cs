using System;

namespace UC3EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Email;
            bool result;
            EmailValidation validateemail = new EmailValidation();
            Console.WriteLine("Enter Email: ");
            Email = Console.ReadLine();
            result = validateemail.emailCheck(Email);
            Console.WriteLine(result);
        }
    }
}
