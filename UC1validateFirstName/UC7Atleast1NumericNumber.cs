using System;

namespace UC7Atleast1NumericNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string Numeric;
            bool result;
            NumericNumberValidate numbervalidate = new NumericNumberValidate();
            Console.WriteLine("Enter Password: ");
            Numeric = Console.ReadLine();
            result = numbervalidate.numericCheck(Numeric);
            Console.WriteLine(result);
        }
    }
}
