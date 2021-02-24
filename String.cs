using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class String
    {
        [TestMethod]
        public void add_nametoindex_nameatindexzero()
        {

            CustomList<string> collectionofnames = new CustomList<string>();

            string name = "lara";
            string expected = "lara";
            string actual;

            // act           
            collectionofnames.AddMethod(name);
            actual = collectionofnames.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_CountOfStringsTwo()
        {

            CustomList<string> collectionOfNames = new CustomList<string>();

            string name = "Lara";
            string name1 = "Eve";
            string expected = "LaraEve";
            string actual;

            // Act           
            collectionOfNames.AddMethod(name);
            collectionOfNames.AddMethod(name1);
            actual = collectionOfNames.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_IndexCapacityFour()
        {

            CustomList<int> collectionOfNumbers = new CustomList<int>();

            int number1 = 2;
            int number2 = 3;
            int number3 = 4;
            string expected = "234";
            string actual;

            // Act

            collectionOfNumbers.AddMethod(number1);
            collectionOfNumbers.AddMethod(number2);
            collectionOfNumbers.AddMethod(number3);
            actual = collectionOfNumbers.ToString(); 

            // Assert
            Assert.AreEqual(expected, actual);
        }





    }
}
