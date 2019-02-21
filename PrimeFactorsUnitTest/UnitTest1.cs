using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberProgram;

namespace PrimeFactorsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnPrimeFactorsCorrect()
        {
            var primeFactors = Program.GetPrimeFactors(36);

            int value = 1;
            foreach (int x in primeFactors)
            {
                value = x * value;
            }

            Assert.IsTrue(value == 36);
        }

        [TestMethod]
        public void ReturnPrimeFactorsNegative()
        {
            var primeFactors = Program.GetPrimeFactors(-36);

            int value = 1;
            foreach (int x in primeFactors)
            {
                value = x * value;
            }

            Assert.IsTrue(value == 1);
            Assert.IsTrue(primeFactors.Count == 0);
        }

        [TestMethod]
        public void ReturnPrimeFactorsZero()
        {
            var primeFactors = Program.GetPrimeFactors(0);

            int value = 1;
            foreach (int x in primeFactors)
            {
                value = x * value;
            }

            Assert.IsTrue(value == 1);
            Assert.IsTrue(primeFactors.Count == 0);
        }
    }
}
