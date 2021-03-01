using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    public class Zip
    {
        [TestMethod]
        public void Zip_ListOneandListTwo_ResultIsListOneandListTwo()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };

            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual = CustomList<int>.Zip(one, two);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_ListTwoIsLongerThanListOne_ResultIsListOneandListTwo()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 , 7 };

            CustomList<int> expected = new CustomList<int> { 2,1,4,3,6,5,7 };
            CustomList<int> actual = CustomList<int>.Zip(one, two);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
