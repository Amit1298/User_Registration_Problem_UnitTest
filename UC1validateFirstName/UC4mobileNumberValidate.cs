using System;

namespace UC4mobileNumberValidate
{
    class Program
    {
        static void Main(string[] args)
        {
            string MobileNumber;
            bool result;
            MobileNumberValidate mobileNumbervalidate = new MobileNumberValidate();
            Console.WriteLine("Enter Mobile Number: ");
            MobileNumber = Console.ReadLine();
            result = mobileNumbervalidate.phoneNumberCheck(MobileNumber);
            Console.WriteLine(result);
        }
    }
}
