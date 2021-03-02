using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class String
    {
        [TestMethod]
        public void Add_StringToIndex_StringAddedLara()
        {

            CustomList<string> collectionofnames = new CustomList<string>();

            string name = "lara";
            string expected = "lara";
            string actual;

            // act           
            collectionofnames.Add(name);
            actual = collectionofnames.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_ConcatenatedStringsLaraEve()
        {

            CustomList<string> collectionOfNames = new CustomList<string>();

            string name = "Lara";
            string name1 = "Eve";
            string expected = "LaraEve";
            string actual;

            // Act           
            collectionOfNames.Add(name);
            collectionOfNames.Add(name1);
            actual = collectionOfNames.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_ExpectedString234()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number1 = 2;
            int number2 = 3;
            int number3 = 4;
            string expected = "234";
            string actual;

            // Act

            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            actual = collectionOfNumbers.ToString(); 

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_ExpectedString2345()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number1 = 2;
            int number2 = 3;
            int number3 = 4;
            int number4 = 5;
            string expected = "2345";
            string actual;

            // Act

            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            collectionOfNumbers.Add(number4);
            actual = collectionOfNumbers.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }






    }
}
