using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTestAdd
    {
        [TestMethod]
        public void AddToList_CheckListIndex1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int expected = 3;



            // act
            myList.AddToList(number1);
            int actual = myList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToList_CheckListIndex2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int expected = 5;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            int actual = myList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_CheckCounter1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int expected = 2;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            int actual = myList.count;


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_CheckCounter2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int number2 = 5;
            int number3 = 7;
            int expected = 3;



            // act
            myList.AddToList(number1);
            myList.AddToList(number2);
            myList.AddToList(number3);
            int actual = myList.count;


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_CheckCapacity1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int expected = 4;
            // act

            for (int i = 0; i <= 3; i++)
            {
                myList.AddToList(number1);
            }

            int actual = myList.capacity;


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_CheckCapacity2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;
            int expected = 8;

            // act
            for (int i = 0; i <= 6; i++)
            {
                myList.AddToList(number1);
            }

            int actual = myList.capacity;


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_CheckCapacity3()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 3;

            int expected = 16;


            // act
            for (int i = 0; i <= 9; i++)
            {
                myList.AddToList(number1);

            }
            int actual = myList.capacity;



            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}


