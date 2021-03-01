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
        public void Zip_ListOneandListTwo_ResultIs123456()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };

            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual = CustomList<int>.Zip(one, two);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_ListTwoIsLongerThanListOne_2143658()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 , 8 };

            CustomList<int> expected = new CustomList<int> { 2,1,4,3,6,5,8 };
            CustomList<int> actual = CustomList<int>.Zip(one, two);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Zip_ListOneIsLongerThanListTwo_ResultIs1234567()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6};

            CustomList<int> expected = new CustomList<int> {1,2,3,4,5,6,7};
            CustomList<int> actual = CustomList<int>.Zip(one, two);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Zip_ListOneIsEmpty_ResultIsTwoFourSix()
        {
            CustomList<int> one = new CustomList<int>() {};
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };

            CustomList<int> expected = new CustomList<int> { 2,4,6 };
            CustomList<int> actual = CustomList<int>.Zip(one, two);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
