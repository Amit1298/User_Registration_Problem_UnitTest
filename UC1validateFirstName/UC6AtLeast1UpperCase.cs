using System;

namespace UC6AtLeast1UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pass;
            bool result;
            UpperCaseValidate uppercasevalidate = new UpperCaseValidate();
            Console.WriteLine("Enter Password: ");
            Pass = Console.ReadLine();
            result = uppercasevalidate.UpperCaseCheck(Pass);
            Console.WriteLine(result); ;
        }
    }
}
