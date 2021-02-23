using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    class Remove
    {
        [TestMethod]
        public void Remove_Item_CountDecreasesByOne()
        {
            
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int expected = 1;
            int actual;

            // Act
            collectionOfNumbers.AddMethod(number);
            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.RemoveMethod(number);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
