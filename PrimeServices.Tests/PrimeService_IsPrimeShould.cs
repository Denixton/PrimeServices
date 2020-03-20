using NUnit.Framework;
using PrimeServices;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    { 
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        public void IsPrimeTest(int value)
        {
            PrimeService primeService = CreatePrimeService();
            var result = primeService.IsPrime(value);

            Assert.IsTrue(result, $"{value} is prime");
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        public void IsNotPrimeTest(int value)
        {
            PrimeService primeService = CreatePrimeService();
            var result = primeService.IsPrime(value);

            Assert.IsTrue(result, $"{value} should not be prime");
        }


        /*
        More tests
        */

        private PrimeService CreatePrimeService()
        {
            return new PrimeService();
        }
    }
}