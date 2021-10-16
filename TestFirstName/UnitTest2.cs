using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2validateLastName;

namespace TestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool exception = true;
            ValidateLastName validate = new ValidateLastName();
            bool name = validate.lastNameCheck("Sumi");
            Assert.AreEqual(exception, name);
        }
    }
}
