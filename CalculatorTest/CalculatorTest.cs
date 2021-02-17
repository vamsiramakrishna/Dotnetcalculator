using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAddition1() //To test addition with integer value
        {
            double num1 = 3;
            double num2 = 6 ;
            double result = 9;
            double actual_result = CalculatorApp.CalcOperations.Addition(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestAddition2() //To test addition with decimal value
        {
            double num1 = 36.266;
            double num2 = 63.545;
            double result = 99.81;
            double actual_result = CalculatorApp.CalcOperations.Addition(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestAddition3() //To test addition with negative value for one input
        {
            double num1 = -36;
            double num2 = 6;
            double result = -30;
            double actual_result = CalculatorApp.CalcOperations.Addition(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestAddition4() //To test addition with negative value for both input
        {
            double num1 = -36;
            double num2 = -4;
            double result = -40;
            double actual_result = CalculatorApp.CalcOperations.Addition(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestSubtraction1() //To test subtraction with integer value
        {
            double num1 = 30;
            double num2 = 60;
            double result = -30;
            double actual_result = CalculatorApp.CalcOperations.Subtraction(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestSubtraction2() //To test subtraction with decimal value
        {
            double num1 = 30.96;
            double num2 = 6.45;
            double result = 24.51;
            double actual_result = CalculatorApp.CalcOperations.Subtraction(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestSubtraction3() //To test subtraction with negative value for one input
        {
            double num1 = -30;
            double num2 = 6;
            double result = -36;
            double actual_result = CalculatorApp.CalcOperations.Subtraction(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestSubtraction4() //To test subtraction with negative value for both input
        {
            double num1 = -25;
            double num2 = -5;
            double result = -20;
            double actual_result = CalculatorApp.CalcOperations.Subtraction(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestMultiplication1() //To test multiplication with integer value
        {
            double num1 = 30;
            double num2 = 6;
            double result = 180;
            double actual_result = CalculatorApp.CalcOperations.Multiplication(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestMultiplication2() //To test multiplication with decimal value
        {
            double num1 = 30.89;
            double num2 = 6.68;
            double result = 206.35;
            double actual_result = CalculatorApp.CalcOperations.Multiplication(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestMultiplication3() //To test multiplication with negative value for one input
        {
            double num1 = -25;
            double num2 = 8;
            double result = -200;
            double actual_result = CalculatorApp.CalcOperations.Multiplication(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestMultiplication4() //To test multiplication with negative value for both input
        {
            double num1 = -20;
            double num2 = -5;
            double result = 100;
            double actual_result = CalculatorApp.CalcOperations.Multiplication(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision1() //To test division with integer value
        {
            double num1 = 30;
            double num2 = 10;
            double result = 3;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision2() //To test division with decimal value
        {
            double num1 = 30.65;
            double num2 = 5.4;
            double result = 5.68;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision3() //To test division with negative value for one input
        {
            double num1 = -30;
            double num2 = 10;
            double result = -3;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision4() //To test division with negative value for both input
        {
            double num1 = -30.65;
            double num2 = -5.4;
            double result = 5.68;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision5() //To test division by zero for positive number
        {
            double num1 = 30;
            double num2 = 0;
            double result = double.PositiveInfinity;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision6() //To test division by zero for negative number
        {
            double num1 = -30;
            double num2 = 0;
            double result = double.NegativeInfinity;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }

        [TestMethod]
        public void TestDivision7() //To test division zero by zero
        {
            double num1 = 0;
            double num2 = 0;
            double result = double.NaN;
            double actual_result = CalculatorApp.CalcOperations.Division(num1, num2);
            Assert.AreEqual(result, actual_result);
        }
    }
}
