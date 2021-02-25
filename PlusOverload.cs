using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListUnitTestProj;

namespace CustomListUnitTest
{
    [TestClass]
    class PlusOverload

    {
        [TestMethod]
        public void Add_ItemsToLists_StringListsOfCountsOfThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();


            int number = 1;
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            string expected = "1,3,5,3,7,1";
            string actual;

            // Act

            one.AddMethod(number); //1
            one.AddMethod(number1); //3
            one.AddMethod(number2);//5
            two.AddMethod(number1); //3
            two.AddMethod(number3); //7
            two.AddMethod(number); //1


            actual = one + two;


            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Add_ItemsToLists_ListOneHasFiveValuesListTwoHasThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();


            int number = 1;
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int number4 = 8;
            int number5 = 9;
            string expected = "1,3,5,8,9,3,7,1";
            string actual;

            // Act

            one.AddMethod(number); //1
            one.AddMethod(number1); //3
            one.AddMethod(number2);//5
            one.AddMethod(number4); //8
            one.AddMethod(number5); //9
            two.AddMethod(number1); //3
            two.AddMethod(number3); //7
            two.AddMethod(number); //1


            actual = one + two;


            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Add_ItemsToLists_ListTwoHasFiveValuesListOneHasThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();


            int number = 1;
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int number4 = 8;
            int number5 = 9;
            string expected = "1,3,5,3,7,1,8,9";
            string actual;

            // Act

            one.AddMethod(number); //1
            one.AddMethod(number1); //3
            one.AddMethod(number2);//5
            two.AddMethod(number1); //3
            two.AddMethod(number3); //7
            two.AddMethod(number); //1
            two.AddMethod(number4); //8
            two.AddMethod(number5); //9


            actual = one + two;


            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }
    }
}


