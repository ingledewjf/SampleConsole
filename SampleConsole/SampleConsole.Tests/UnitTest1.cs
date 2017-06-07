namespace SampleConsole.Tests
{
    using BusinessLogic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FlipWorksCorrectly()
        {
            var actual = Utility.Flip(2, 1);
            Assert.AreEqual(-1, actual);
        }
    }
}
