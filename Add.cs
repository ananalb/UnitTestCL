using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class Add
    {
        [TestMethod]
        public void Add_Item_CountIncreasesByOne()
        {

            // checking the index of the item on your CustomList<T> to make sure it was added
            // check the capacity of our list to make sure it increases when we add an item beyond the original capacity

            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int expected = 1;
            int actual;

            // Act

            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ItemToIndex_IndexCapacityFour()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int expected = 4;
            int actual;

            // Act

            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ItemToIndex_IndexAtZero()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int expected = 9;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(number);
            actual = collectionOfNumbers[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ItemsToList_()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int number3 = 12;
            int number4 = 13;
            int expected = 5;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(number);
            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.AddMethod(number2);
            collectionOfNumbers.AddMethod(number3);
            collectionOfNumbers.AddMethod(number4);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

