using CalcAgain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcAgainTests
{
    [TestClass]
    public class InputReaderTests
    {
        [TestMethod]
        public void UpdateInputTest()
        {
            //Given
            InputReader inputReader = new InputReader
            {
                Input = "123"
            };
            string enteredInput = "4";

            //When
            inputReader.UpdateInput(enteredInput);

            //Then
            Assert.AreEqual("1234", inputReader.Input);
        }

        [TestMethod]
        public void TrimmingZeroOnBeginOfInput()
        {
            //Given
            InputReader inputReader = new InputReader
            {
                Input = "0"
            };
            string enteredInput = "4";

            //When
            inputReader.UpdateInput(enteredInput);

            //Then
            Assert.AreEqual("4", inputReader.Input);
        }

        [TestMethod]
        public void AddCommaToInputTest()
        {
            //Given
            InputReader inputReader = new InputReader
            {
                Input = "123"
            };

            //When
            inputReader.AddCommaToInput();

            //Then
            Assert.AreEqual($"123{Configuration.DecimalSeparator}", inputReader.Input);
        }

        [TestMethod]
        public void TryAddCommaToInputWithCommaTest()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = $"123{Configuration.DecimalSeparator}";

            //When
            inputReader.AddCommaToInput();

            //Then
            Assert.AreEqual($"123{Configuration.DecimalSeparator}", inputReader.Input);
        }

        [TestMethod]
        public void ChangePlusToMinusSignTest()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = "123";

            //When
            inputReader.ChangePlusMinusSign();

            //Then
            Assert.AreEqual("-123", inputReader.Input);
        }

        [TestMethod]
        public void ChangeMinusToPlusSignTest()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = "-123";

            //When
            inputReader.ChangePlusMinusSign();

            //Then
            Assert.AreEqual("123", inputReader.Input);
        }

        [TestMethod]
        public void DeleteLastCharacterOfInputTest()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = "-123";

            //When
            inputReader.DeleteLastCharacter();

            //Then
            Assert.AreEqual("-12", inputReader.Input);
        }

        [TestMethod]
        public void DeleteLastCharacterOfOneNumberInputTest()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = "9";

            //When
            inputReader.DeleteLastCharacter();

            //Then
            Assert.AreEqual("0", inputReader.Input);
        }
    }
}
