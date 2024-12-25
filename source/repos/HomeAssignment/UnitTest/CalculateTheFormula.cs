using NUnit.Framework;
using CalculatetheFormula;


namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCalS1()
        {
            Assert.AreEqual(0.5, CalculatetheFormula.CalS1(1), 1e-10);
            Assert.AreEqual(0.3611111111111111, CalculatetheFormula.CalS1(2), 1e-10);
        }

        [Test]
        public void TestCalS2()
        {
            Assert.AreEqual(-1, CalculatetheFormula.CalS2(1), 1e-10);
            Assert.AreEqual(1.5, CalculatetheFormula.CalS2(2), 1e-10);
        }

        [Test]
        public void TestCalS5()
        {
            Assert.AreEqual(0.5, CalculatetheFormula.CalS5(1), 1e-10);
            Assert.AreEqual(0.25, CalculatetheFormula.CalS5(2), 1e-10);
        }

        [Test]
        public void TestCalS6()
        {
            Assert.AreEqual(1, CalculatetheFormula.CalS6(1), 1e-10);
            Assert.AreEqual(0.5, CalculatetheFormula.CalS6(2), 1e-10);
        }

        [Test]
        public void TestCalS7()
        {
            Assert.AreEqual(3, CalculatetheFormula.CalS7(1), 1e-10);
            Assert.AreEqual(5, CalculatetheFormula.CalS7(2), 1e-10);
        }

        [Test]
        public void TestFactorial()
        {
            Assert.AreEqual(1, CalculatetheFormula.Factorial(0));
            Assert.AreEqual(1, CalculatetheFormula.Factorial(1));
            Assert.AreEqual(2, CalculatetheFormula.Factorial(2));
            Assert.AreEqual(6, CalculatetheFormula.Factorial(3));
            Assert.AreEqual(24, CalculatetheFormula.Factorial(4));
        }
    }
}
