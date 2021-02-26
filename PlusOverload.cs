using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;

            // Act

            one.AddMethod(number); //1
            one.AddMethod(number1); //3
            one.AddMethod(number2);//5
            two.AddMethod(number1); //3
            two.AddMethod(number3); //7
            two.AddMethod(number); //1


            actual = one + two;
            


            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
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
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;

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
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Add_ItemsToLists_ListTwoHasFiveValuesListOneHasThree()
        {

            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();


            int number =  1;
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int number4 = 8;
            int number5 = 9;
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;

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
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}


