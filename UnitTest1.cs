namespace Tdd_SQA
{
    public class Tests
    {
        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void OnePlusOneTest()
        {
            Assert.AreEqual(2, cal.addInteger(1, 1));
        }
        [Test]
        public void DoublePlusDouble() {
            Assert.AreEqual(2.5, cal.addDouble(1.3, 1.2));


        }
        [Test]
        public void StringPlusString()
        {
            Assert.AreEqual("HELLOWORLD", cal.addStrings("HELLO", "WORLD"));


        }
        [Test]
        public void FloatPlusFloat()
        {
            Assert.AreEqual(5.3f, cal.addFloat(4.1f, 1.2f));

        }
        [Test]
        public void FloatMinusFloat()
        {
            Assert.AreEqual(3f, cal.substractFloat(4.1f, 1.1f));

        }
        [Test]
        public void FloatMinusFloats()
        {
            Assert.AreEqual(1f, cal.substractFloat(4.1f, 1.1f));

        }
        [Test]
        public void DoubleMinusDouble()
        {
            Assert.AreEqual(1.0, cal.substractDouble(4.1, 1.1));
        }
        [Test]
        public void SubstractDouble_PositiveAndNegativeNumbers()
        {
            Assert.AreEqual(6.0, cal.substractDouble(2.0, -4.0));
        }
        [Test]
        public void SubstractDouble_NegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(-2.0, cal.substractDouble(-1.0, -1.0));
        }
        [Test]
        public void SubstractDouble_PositiveAndNegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(6.0, cal.substractDouble(2.0, -4.0));
        }
        [Test]
        public void SubstractDouble_ZeroAsSecondOperand_ResultIsCorrect()
        {
            Assert.AreEqual(3.6, cal.substractDouble(3.7, 0.0));
        }
        [Test]
        public void SubstractFloat_PositiveAndNegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(6.0f, cal.substractFloat(2.0f, -4.0f));
        }

        [Test]
        public void SubstractFloat_ZeroAsSecondOperand_ResultIsCorrect()
        {
            Assert.AreEqual(3.7f, cal.substractFloat(3.7f, 0.0f));
        }
        [Test]
        public void AddInteger_NegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(-2, cal.addInteger(-1, -1));
        }

        [Test]
        public void AddInteger_PositiveAndNegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(1, cal.addInteger(2, -1));
        }

        [Test]
        public void AddInteger_ZeroAsSecondOperand_ResultIsCorrect()
        {
            Assert.AreEqual(3, cal.addInteger(3, 0));
        }

        [Test]
        public void AddInteger_LargeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(1000000000, cal.addInteger(500000000, 500_000_000));
        }
        [Test]
        public void AddInteger_LargeNumber_ResultIsCorrect()
        {
            Assert.AreEqual(12, cal.multiplyDouble(4, 3));
        }
        [Test]
        public void MultiplyDouble_NegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(-12.0, cal.multiplyDouble(-4.0, 3.0));
        }

        [Test]
        public void MultiplyDouble_PositiveAndNegativeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(-12.0, cal.multiplyDouble(4.0, -3.0));
        }

        [Test]
        public void MultiplyDouble_ZeroAsOperand_ResultIsCorrect()
        {
            Assert.AreEqual(0.0, cal.multiplyDouble(5.0, 0.0));
        }

        [Test]
        public void MultiplyDouble_LargeNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(2.0e9, cal.multiplyDouble(1.0e9, 2.0));
        }

        [Test]
        public void MultiplyDouble_DecimalNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(0.24, cal.multiplyDouble(0.2, 1.2));
        }
        [Test]
        public void MultiplyDouble_DecimalNumber_ResultIsCorrect()
        {
            Assert.AreEqual(0.2, cal.multiplyDouble(1.0, 5.0));
        }
        [Test]
        public void MultiplyDouble_Negative_ResultIsCorrect()
        {
            Assert.AreEqual(-12.0, cal.multiplyDouble(-4.0, 3.0));
        }

        [Test]
        public void MultiplyDouble_PositiveAndNegativeN_ResultIsCorrect()
        {
            Assert.AreEqual(-12.0, cal.multiplyDouble(4.0, -3.0));
        }

        [Test]
        public void MultiplyDouble_ZeroAsOper_ResultIsCorrect()
        {
            Assert.AreEqual(0.0, cal.multiplyDouble(5.0, 0.0));
        }

        [Test]
        public void MultiplyDouble_LargeNumbe_ResultIsCorrect()
        {
            Assert.AreEqual(2.0e9, cal.multiplyDouble(1.0e9, 2.0));
        }

        [Test]
        public void MultiplyDouble_DecimalNumbe_ResultIsCorrect()
        {
            Assert.AreEqual(0.24, cal.multiplyDouble(0.2, 1.2));
        }

        [Test]
        public void MultiplyDouble_DecimalNumbers_ResultIsCorrect()
        {
            Assert.AreEqual(5.0, cal.multiplyDouble(1.0, 5.0));
        }



    }
}