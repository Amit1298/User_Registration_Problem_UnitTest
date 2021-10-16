using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1validateFirstName;

namespace TestFirstName
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            bool expection = true;
            ValidateFirstName validate = new ValidateFirstName();
            bool name = validate.firstNameCheck("Amit");
            Assert.AreEqual(expection, name);
        }
    }
}
