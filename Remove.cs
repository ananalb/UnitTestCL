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

        [TestMethod]
        public void Remove_ItemFromIndex_IndexCapacityFour()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int expected = 4;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(number);
            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.AddMethod(number2);
            collectionOfNumbers.RemoveMethod(number1);
            collectionOfNumbers.RemoveMethod(number2);
            actual = collectionOfNumbers.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
