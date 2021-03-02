using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class PlusOverload

    {
        [TestMethod]
        public void Add_ItemsToLists_StringListsOfCountsOfThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 3, 7, 1 };

            CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 3, 7, 1 };
            CustomList<int> actual;

            // Act

            actual = one + two;
            


            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Add_ItemsToLists_ListOneHasFiveValuesListTwoHasThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 8, 9 };
            CustomList<int> two = new CustomList<int>() { 3, 7, 1 };

            CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 8, 9, 3, 7, 1 };
            CustomList<int> actual;

            // Act

            actual = one + two;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Add_ItemsToLists_ListTwoHasFiveValuesListOneHasThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>() { 1,3,5};
            CustomList<int> two = new CustomList<int>() { 3,7,1,8,9};

            CustomList<int> expected = new CustomList<int>() {1,3,5,3,7,1,8,9};
            CustomList<int> actual;

            // Act


            actual = one + two;


            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}


