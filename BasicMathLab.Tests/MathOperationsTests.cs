namespace BasicMathLab.Tests
{
    public class Tests
    {
        private MathOperations mathOperations;

        [SetUp]
        public void Setup()
        {
            mathOperations = new MathOperations();
        }

        [Test]
        public void TestAddEightPlusOne()
        {
            double expected = 9;
            double actual = mathOperations.Add(8, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSubtractThreeFromTen()
        {
            double expected = 7;
            double actual =mathOperations.Subtract(10, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiplyTenTimesTwo()
        {
            double expected = 20;
            double actual = mathOperations.Multiply(10, 2);
            
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDivideTwelveByTwo()
        {
            double expected = 6;
            double actual = mathOperations.Divide(12, 2);

            Assert.AreEqual(expected, actual);
        }

    }
}