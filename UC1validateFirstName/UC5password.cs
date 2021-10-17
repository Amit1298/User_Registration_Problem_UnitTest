using System;

namespace UC5password
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pass;
            bool result;
            PasswordValidate passwordvalidate = new PasswordValidate();
            Console.WriteLine("Enter Your Password: ");
            Pass = Console.ReadLine();
            result = passwordvalidate.passwordCheck(Pass);
            Console.WriteLine(result);
        }
    }
}
