using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcAgain;

namespace CalcAgainTests
{
    [TestClass]
    public class CalculationsTests
    {
        [TestMethod]
        public void AddTest()
        {
            //Given
            var action = Action.Add;
            double firstValue = 4;
            double secondValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(action, firstValue, secondValue);
            //Then
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ExtractTest()
        {
            //Given
            var action = Action.Extract;
            double firstValue = 4;
            double secondValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(action, firstValue, secondValue);
            //Then
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultipleTest()
        {
            //Given
            var action = Action.Multiple;
            double firstValue = 4;
            double secondValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(action, firstValue, secondValue);
            //Then
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void DivideTest()
        {
            //Given
            var action = Action.Divide;
            double firstValue = 4;
            double secondValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(action, firstValue, secondValue);
            //Then
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            //Given
            var action = Action.Divide;
            double firstValue = 4;
            double secondValue = 0;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(action, firstValue, secondValue);
            //Then
            Assert.IsTrue(double.IsInfinity(result));
        }
    }
}
