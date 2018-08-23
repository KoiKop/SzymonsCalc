using CalcAgain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcAgainTests
{
    [TestClass]
    public class InputStorageTests
    {
        [TestMethod]
        public void StoreLValueWhenActionInitial()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = "234";
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = CalcAgain.Action.Initial;

            //When
            inputStorage.StoreValue(inputReader);

            //Then
            Assert.AreEqual(234, inputStorage.LValue);
        }

        [TestMethod]
        public void StoreRValueWhenActionIsNotInitial()
        {
            //Given
            InputReader inputReader = new InputReader();
            inputReader.Input = "234";
            InputStorage inputStorage = new InputStorage();
            inputStorage.Action = CalcAgain.Action.Add;

            //When
            inputStorage.StoreValue(inputReader);

            //Then
            Assert.AreEqual(234, inputStorage.RValue);
        }
    }
}
