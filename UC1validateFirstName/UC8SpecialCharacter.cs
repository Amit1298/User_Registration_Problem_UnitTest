using System;

namespace UC8SpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string SpecialChar;
            bool result;
            SpecialCharacterValidate specialCharvalidate = new SpecialCharacterValidate();
            Console.WriteLine("Enter Your Password: ");
            SpecialChar = Console.ReadLine();
            result = specialCharvalidate.SpecialCharCheck(SpecialChar);
            Console.WriteLine(result);
        }
    }
}
