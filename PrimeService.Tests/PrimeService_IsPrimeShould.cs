using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService? _primeService;

        // Methods need to be public (as before JUnit 5.x)

        [SetUp]
        public void SetUp() // meh, SetUp needs 2b public
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool isPrime = _primeService.IsPrime(1);
            Assert.IsFalse(isPrime, "1 should not be prime");
        }

        [Test]
        public void IsPrime_InputIsZero_ReturnFalse()
        {
            bool isPrime = _primeService.IsPrime(0);
            Assert.IsFalse(isPrime, "0 should not be prime");
        }


        [Test]
        public void IsPrime_InputIsNegative_ReturnFalse()
        {
            bool isPrime = _primeService.IsPrime(-24);
            Assert.IsFalse(isPrime, "-24 should not be prime");
        }

        [Test]
        [TestCase(-42, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(8, false)]
        [Parallelizable(ParallelScope.All)]
        public void IsPrime_SomeInputValues_ResultIsAsSpecified(int candidate, bool expectedResult)
        {
            bool isPrime = _primeService.IsPrime(candidate);
            string msg = candidate + " is " + (expectedResult == false ? "NOT" : "") + " supposed to be a prime number.";
            Assert.AreEqual(expectedResult, isPrime, msg);
        }


    }
}