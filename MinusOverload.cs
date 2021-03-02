using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class MinusOverload
    {
        [TestMethod]
        public void Remove_ItemsFromListOne_ResultIsFive()
        {

            //arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 3, 7, 1 };

            CustomList<int> expected = new CustomList<int> { 5 };
            CustomList<int> actual;

            actual = one - two;

            // assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }


        [TestMethod]
        public void Remove_ItemsFromListOne_ExpectedResultIs589()
        {

            //arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 8, 9 };
            CustomList<int> two = new CustomList<int>() { 3, 7, 1 };

            CustomList<int> expected = new CustomList<int>() { 5,8,9};
            CustomList<int> actual;


            actual = one - two;


            // assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Remove_MinusFromListTwo_ExpectedResultIs7()
        {

            //arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 3, 7, 1 };

            CustomList<int> expected = new CustomList<int>() { 7 };
            CustomList<int> actual;

            // act
            actual = two - one;

            // assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Remove_EmptyListTwofromListOne_ResultIs135()
        {

            //arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() {};

            CustomList<int> expected = new CustomList<int>() { 1,3,5 };
            CustomList<int> actual;

            // act
            actual = one - two;

            // assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
