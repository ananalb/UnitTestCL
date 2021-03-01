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
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();


            int number = 1;
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;

            // Act

            one.Add(number); //1
            one.Add(number1); //3
            one.Add(number2);//5
            two.Add(number1); //3
            two.Add(number3); //7
            two.Add(number); //1

            expected.Add(number); //1
            expected.Add(number1); //3
            expected.Add(number2);//5
            expected.Add(number1); //3
            expected.Add(number3); //7
            expected.Add(number); //1

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

            one.Add(number); //1
            one.Add(number1); //3
            one.Add(number2);//5
            one.Add(number4); //8
            one.Add(number5); //9
            two.Add(number1); //3
            two.Add(number3); //7
            two.Add(number); //1

            expected.Add(number);//1
            expected.Add(number1); //3
            expected.Add(number2);//5
            expected.Add(number4); //8
            expected.Add(number5); //9
            expected.Add(number1); //3
            expected.Add(number3); //7
            expected.Add(number); //1



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

            one.Add(number); //1
            one.Add(number1); //3
            one.Add(number2);//5
            two.Add(number1); //3
            two.Add(number3); //7
            two.Add(number); //1
            two.Add(number4); //8
            two.Add(number5); //9

            expected.Add(number); //1
            expected.Add(number1); //3
            expected.Add(number2);//5
            expected.Add(number1); //3
            expected.Add(number3); //7
            expected.Add(number); //1
            expected.Add(number4); //8
            expected.Add(number5); //9


            actual = one + two;


            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}


