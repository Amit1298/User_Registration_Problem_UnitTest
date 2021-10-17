using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC4mobileNumberValidate;

namespace TestProject4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expection = true;
            MobileNumberValidate validate = new MobileNumberValidate();
            bool name = validate.phoneNumberCheck("91 9897139203");
            Assert.AreEqual(expection, name);
        }
    }
}
