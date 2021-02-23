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
        [TestMethod]
        public void Remove_ItemFromIndex_IndexAtZeroIsTen()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int expected = 10;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(number); 
            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.AddMethod(number2);
            collectionOfNumbers.RemoveMethod(number); 
            actual = collectionOfNumbers[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_ItemFromList_CountOfSix()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int number3 = 12;
            int number4 = 13;
            int number5 = 14;
            int number6 = 15;
            int expected = 6;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(number);
            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.AddMethod(number2);
            collectionOfNumbers.AddMethod(number3);
            collectionOfNumbers.AddMethod(number4);
            collectionOfNumbers.AddMethod(number5);
            collectionOfNumbers.AddMethod(number6);
            collectionOfNumbers.RemoveMethod(number);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemsFromIndex_IndexCapacityEight()
        {
            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int number3 = 12;
            int number4 = 13;
            int number5 = 14;
            int number6 = 15;
            int expected = 8;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(number);
            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.AddMethod(number2);
            collectionOfNumbers.AddMethod(number3);
            collectionOfNumbers.AddMethod(number4);
            collectionOfNumbers.AddMethod(number5);
            collectionOfNumbers.AddMethod(number6);
            collectionOfNumbers.RemoveMethod(number);
            collectionOfNumbers.RemoveMethod(number1);
            actual = collectionOfNumbers.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
