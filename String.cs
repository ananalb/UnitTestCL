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

            CustomList<string> collectionOfNumbers = new CustomList<string>();

            string name = "Lara";
            string expected = "Lara";
            string actual;

            // Act           
            collectionOfNumbers.AddMethod(name);
            actual = collectionOfNames[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
