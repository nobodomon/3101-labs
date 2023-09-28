using Moq;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<FileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<FileReader>();
            _mockFileReader.Setup( fr =>
               fr.Read("MagicNumbers.txt")).Returns(new string[]{
                "10",
                "20",
                "30",
                "40",
                "50",
                "69",
                "420",
                "\n",
                "abc",
                "-300",
                "1.7976931348623157E+309",
                "-1.7976931348623157E+309",
                "12.3.4.5",
                "10*10"
                });
            _calculator = new Calculator();
        }

        [Test]
        // magic number test case
        public void GenMagicNum_PositiveInput_ReturnsDouble()
        {
            double result = _calculator.GenMagicNum(2,  _mockFileReader.Object);
            Assert.AreEqual(60, result);
        }

        [Test]
        public void GenMagicNum_NegativeInput_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(-3,  _mockFileReader.Object);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GenMagicNum_OutOfBoundsInput_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(100,  _mockFileReader.Object);
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void GenMagicNum_BlankLine_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(7,  _mockFileReader.Object);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void GenMagicNum_NonNumeric_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(8,  _mockFileReader.Object);
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void GenMagicNum_NegativeNumber_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(9,  _mockFileReader.Object);
            Assert.AreEqual(600, result);
        }
        [Test]
        public void GenMagicNum_NumberBiggerThanDouble_PositiveInfinity()
        {
            double result = _calculator.GenMagicNum(10,  _mockFileReader.Object);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [Test]
        public void GenMagicNum_NumberSmallerThanDouble_PositiveInfinity()
        {
            double result = _calculator.GenMagicNum(11,  _mockFileReader.Object);
            Assert.AreEqual(double.PositiveInfinity , result);
        }
        [Test]
        public void GenMagicNum_NumberWithMultipleDecimalPoints_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(12,  _mockFileReader.Object);
            Assert.AreEqual(0 , result);
        }
        [Test]
        public void GenMagicNum_NumberWithExpression_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(13,  _mockFileReader.Object);
            Assert.AreEqual(0 , result);
        }
    }
}