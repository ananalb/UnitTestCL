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
        public void Remove_MinusFromListOne_ExpectedResultIsFiveEightNine()
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
        public void Remove_MinusFromListTwo_ExpectedResultIsSeven()
        {

            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();


            int number = 1;
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            CustomList<int> expected = new CustomList<int>() { 7 };
            CustomList<int> actual;

            // act

            one.Add(number); //1
            one.Add(number1); //3
            one.Add(number2);//5
            two.Add(number1); //3
            two.Add(number3); //7
            two.Add(number); //1


            actual = two - one;


            // assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
