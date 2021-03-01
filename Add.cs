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
        public void Add_ItemToIndex_IndexAtZeroIsNine()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int expected = 9;
            int actual;

            // Act

            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ItemToIndex_IndexAtOneIsTen()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int expected = 10;
            int actual;

            // Act
            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            actual = collectionOfNumbers[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Add_ItemsToList_CountOfFive()
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

            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            collectionOfNumbers.Add(number4);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_ItemsToList_CapacityOfEight()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int number3 = 12;
            int number4 = 13;
            int expected = 8;
            int actual;

            // Act

            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            collectionOfNumbers.Add(number4);
            actual = collectionOfNumbers.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}

