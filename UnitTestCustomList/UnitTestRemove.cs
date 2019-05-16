using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTestRemove
    {
        [TestMethod]
        public void RemoveFromList_CheckListIndex1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int expected = 5;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            myList.RemoveFromList(number1);
            int actual = myList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveFromList_CheckListIndex2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int number4 = 9;
            int expected = 9;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            myList.AddToList(number3);
            myList.AddToList(number4);
            myList.RemoveFromList(number3);
            int actual = myList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveFromList_CheckCounter1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int expected = 1;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            myList.RemoveFromList(number1);
            int actual = myList.Count;


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveFromList_CheckCounter2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int expected = 2;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            myList.AddToList(number3);
            myList.RemoveFromList(number2);

            int actual = myList.Count;


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveFromList_CheckFalse()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int number4 = 9;
            bool expected = false;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            myList.AddToList(number3);
           

            bool actual = myList.RemoveFromList(number4);


            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
