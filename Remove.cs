using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class Remove
    {
        [TestMethod]
        public void Remove_ItemFromIndex_CountDecreasesByOne()
        {
            
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int expected = 1;
            int actual;

            // Act
            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Remove(number);
            actual = collectionOfNumbers.Count;
           

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemsFromIndex_IndexCapacityFour()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int number2 = 11;
            int expected = 4;
            int actual;

            // Act

            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Remove(number1);
            collectionOfNumbers.Remove(number2);
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

            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Remove(number);
            actual = collectionOfNumbers[0];
           

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_ItemFromList_ExpectedCountOfSix()
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

            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            collectionOfNumbers.Add(number4);
            collectionOfNumbers.Add(number5);
            collectionOfNumbers.Add(number6);
            collectionOfNumbers.Remove(number);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemsFromIndex_IndexCapacityOfEight()
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

            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            collectionOfNumbers.Add(number4);
            collectionOfNumbers.Add(number5);
            collectionOfNumbers.Add(number6);
            collectionOfNumbers.Remove(number);
            collectionOfNumbers.Remove(number1);
            actual = collectionOfNumbers.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemNotInList_CountStaysSame()
        {

            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number = 9;
            int number1 = 10;
            int expected = 2;
            int actual;

            // Act
            collectionOfNumbers.Add(number);
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Remove(500);
            actual = collectionOfNumbers.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
