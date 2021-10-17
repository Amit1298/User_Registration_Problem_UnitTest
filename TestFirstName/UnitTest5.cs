using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC5password;

namespace TestProject5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expection = true;
            PasswordValidate validate = new PasswordValidate();
            bool name = validate.passwordCheck("Yoyo12345");
            Assert.AreEqual(expection, name);
        }
    }
}
