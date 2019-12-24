using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculatorService;

namespace calculator.tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_20_Return20()
        {
            //Arrange
            string input = "20";

            //Act
            var result = _calculator.Add(input);
            int expect = 20;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_1_plus_500_Return501()
        {
            //Arrange
            string input = "1,500";

            //Act
            var result = _calculator.Add(input);
            int expect = 501;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_4_minus_3_Return1()
        {
            //Arrange
            string input = "4,-3";

            //Act
            var result = _calculator.Add(input);
            int expect = 1;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_EmptyInput()
        {
            //Arrange
            string input = "";

            //Act
            var result = _calculator.Add(input);
            int expect = 0;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_MissingNumbersInput()
        {
            //Arrange
            string input = "100,";

            //Act
            var result = _calculator.Add(input);
            int expect = 100;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_InvalidNumbersInput_Return5()
        {
            //Arrange
            string input = "5,tyty";

            //Act
            var result = _calculator.Add(input);
            int expect = 5;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_MaxConstrainNumbers_Return78()
        {
            //Arrange
            string input = "1,2,3,4,5,6,7,8,9,10,11,12";

            //Act
            var result = _calculator.Add(input);
            int expect = 78;

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Add_NewLineDelimiter_Return6()
        {
            //Arrange
            string input = "1\n2,3";

            //Act
            var result = _calculator.Add(input);
            int expect = 6;

            //Assert
            Assert.AreEqual(expect, result);
        }
    }
}