using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    class String
    {
        [TestMethod]
        public void Add_NameToIndex_NameAtIndexZero()
        {

            CustomList<string> collectionOfNames = new CustomList<string>();

            string name = "Lara";
            string expected = "Lara";
            string actual;

            // Act           
            collectionOfNames.AddMethod(name);
            actual = collectionOfNames[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_CountOfStringsTwo()
        {

            CustomList<string> collectionOfNames = new CustomList<string>();

            string name = "Lara";
            string name1 = "Eve";
            int expected = 2;
            int actual;

            // Act           
            collectionOfNames.AddMethod(name);
            collectionOfNames.AddMethod(name1);
            actual = collectionOfNames.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringsToIndex_IndexCapacityFour()
        {

            CustomList<string> collectionOfNumbers = new CustomList<string>();

            string name = "Lara";
            string name1 = "Eve";
            int expected = 4;
            int actual;

            // Act

            collectionOfNumbers.AddMethod(name);
            collectionOfNumbers.AddMethod(name1);
            actual = collectionOfNumbers.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }





    }
}
