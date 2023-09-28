namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(1, 0, null)]
        [TestCase(0, 0, 1)]
        [TestCase(0, 1, 0)]
        //[Ignore("This test is failing as the divide functionality changed.")]
        public void Divide_WhenDividingByZero_ResultEqualToNaN(double a, double b, double? answer)
        {
            try{
                
                // Act
                double result = _calculator.Divide(a, b);
                // Assert
                Assert.That(result, Is.EqualTo(answer));
            }catch{
                // Assert
                Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
            }
        }


        //test case for a factorial operation
        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        public void Factorial_WhenFactorial_ResultEqualToFactorial(double a, double b)
        {
            // Act
            double result = _calculator.Factorial(a);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }

        //test case for a factorial operation with negative numbers
        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void Factorial_WhenFactorialNegativeNumber_ResultEqualToNaN(double a)
        {
            // Assert
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        //test case for calculating area of triangle
        [Test]
        [TestCase(1, 1, 0.5)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 4.5)]
        public void AreaOfTriangle_WhenAreaOfTriangle_ResultEqualToArea(double a, double b, double c)
        {
            // Act
            double result = _calculator.AreaOfTriangle(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(c));
        }

        //test case for calculating area of triangle with negative numbers
        [Test]
        [TestCase(-1, 1)]
        [TestCase(1, -1)]
        [TestCase(-1, -1)]
        public void AreaOfTriangle_WhenAreaOfTriangleNegativeNumber_ResultEqualToNaN(double a, double b)
        {
            // Assert
            Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
        }

        //test case for calculating area of circle
        [Test]
        [TestCase(1, 3.1415926535897932384626433832795)]
        [TestCase(2, 12.566370614359172953850573533118)]
        [TestCase(3, 28.274333882308138424341972731705)]
        public void AreaOfCircle_WhenAreaOfCircle_ResultEqualToArea(double a, double b)
        {
            // Act
            double result = _calculator.AreaOfCircle(a);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }

        //test case for calculating area of circle with negative numbers
        [Test]
        [TestCase(-1)]
        [TestCase(-2)]
        public void AreaOfCircle_WhenAreaOfCircleNegativeNumber_ResultEqualToNaN(double a)
        {
            // Assert
            Assert.That(() => _calculator.AreaOfCircle(a), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4,5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4,5), Throws.ArgumentException);
        }
    }
}