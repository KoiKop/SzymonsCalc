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
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = Action.Add;
            inputStorage.LValue = 4;
            inputStorage.RValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(inputStorage);
            //Then
            Assert.AreEqual("6", result);
        }

        [TestMethod]
        public void ExtractTest()
        {
            //Given
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = Action.Extract;
            inputStorage.LValue = 4;
            inputStorage.RValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(inputStorage);
            //Then
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void MultipleTest()
        {
            //Given
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = Action.Multiple;
            inputStorage.LValue = 4;
            inputStorage.RValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(inputStorage);
            //Then
            Assert.AreEqual("8", result);
        }

        [TestMethod]
        public void DivideTest()
        {
            //Given
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = Action.Divide;
            inputStorage.LValue = 4;
            inputStorage.RValue = 2;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(inputStorage);
            //Then
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            //Given
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = Action.Divide;
            inputStorage.LValue = 4;
            inputStorage.RValue = 0;
            Calculations calculations = new Calculations();
            //When
            var result = calculations.Calculate(inputStorage);
            //Then
            Assert.AreEqual("You can't divide by 0!", result);
        }
    }
}
