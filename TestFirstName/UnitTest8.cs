using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC8SpecialCharacter;

namespace TestProject8
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expectation = true;
            SpecialCharacterValidate validate = new SpecialCharacterValidate();
            bool name = validate.SpecialCharCheck("A233@hd73");
            Assert.AreEqual(expectation, name);
        }
    }
}
