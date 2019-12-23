using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculatorService;

namespace calculator.tests {
    [TestClass]
    public class CalculatorTests {
        private Calculator _calculator;

        public CalculatorTests () {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void TestMethod1 () { }
    }
}