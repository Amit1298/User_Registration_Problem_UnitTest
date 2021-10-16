using System;

namespace UC2validateLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            bool result;
            ValidateLastName validatelastname = new ValidateLastName();
            Console.WriteLine("Enter Last Name: ");
            Name = Console.ReadLine();
            result = validatelastname.lastNameCheck(Name);
            Console.WriteLine(result);
        }
    }
}
