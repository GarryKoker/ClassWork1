using Code;

namespace Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSumm_PositiveNumber()
        {
            Assert.AreEqual(2, Calculator.Sum(1,1));
        }

        [TestMethod]
        public void TestSumm_NegativeNumber()
        {
            Assert.AreEqual(-2, Calculator.Sum(-1, -1));
        }

        [TestMethod]
        public void TestMinus_PositiveNumber()
        {
            Assert.AreEqual(1, Calculator.Minus(2, 1));
        }

        [TestMethod]
        public void TestMinus_NegativeNumber()
        {
            Assert.AreEqual(-1, Calculator.Minus(-2, -1));
        }
    }
}
