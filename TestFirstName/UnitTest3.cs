using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC3EmailValidation;

namespace TestProject3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool exception = true;
            EmailValidation validate = new EmailValidation();
            bool name = validate.emailCheck("Amit@gmail.com");
            Assert.AreEqual(exception, name);
        }
    }
}
