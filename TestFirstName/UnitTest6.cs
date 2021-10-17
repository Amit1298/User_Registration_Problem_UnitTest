using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC6AtLeast1UpperCase;

namespace TestProject6
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expection = true;
            UpperCaseValidate validate = new UpperCaseValidate();
            bool name = validate.UpperCaseCheck("Amit1233456");
            Assert.AreEqual(expection, name);
        }
    }
}
