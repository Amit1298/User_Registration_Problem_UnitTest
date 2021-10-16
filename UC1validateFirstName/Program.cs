using System;

namespace UC1validateFirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            bool result;
            ValidateFirstName validatefirstname = new ValidateFirstName();
            Console.WriteLine("Enter First Name: ");
            Name = Console.ReadLine();
            result = validatefirstname.firstNameCheck(Name);
            Console.WriteLine(result);
        }
    }
}
