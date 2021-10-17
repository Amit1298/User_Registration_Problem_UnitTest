using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC7Atleast1NumericNumber;

namespace TestProject7
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expectation = true;
            NumericNumberValidate validate = new NumericNumberValidate();
            bool name = validate.numericCheck("Amit123213");
            Assert.AreEqual(expectation, name);
        }
    }
}
