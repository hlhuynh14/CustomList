using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTestOperators
    {
        CustomList<int> list1;
        CustomList<int> list2; 
        [TestMethod]
        public void TestAddOperator1()
        {
            // arrange
            
            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int expected = 5;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value1);
            list2.AddToList(value2);
            list2.AddToList(value3);
            CustomList<int> myList = list1 + list2;
            
            int actual = myList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddOperator2()
        {
            // arrange

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int expected = 6;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value1);
            list2.AddToList(value2);
            list2.AddToList(value3);
            CustomList<int> myList = list1 + list2;

            int actual = myList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddOperator3()
        {
            // arrange

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int expected = 7;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value1);
            list2.AddToList(value2);
            list2.AddToList(value3);
            CustomList<int> myList = list1 + list2;

            int actual = myList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddOperator_TestCount()
        {
            // arrange

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int expected = 6;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value1);
            list2.AddToList(value2);
            list2.AddToList(value3);
            CustomList<int> myList = list1 + list2;

            int actual = myList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMinusOperator1()
        {
            // arrange

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int value4 = 9;
            int value5 = 11;
            int expected = 6;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value5);
            list2.AddToList(value4);
            list2.AddToList(value1);
            list1 = list1 - list2; 
            

            int actual = list1[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMinusOperator2()
        {
            // arrange

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int value4 = 9;
            int value5 = 11;
            int expected = 7;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value4);
            list2.AddToList(value2);
            list2.AddToList(value5);
            list1 = list1 - list2;
            

            int actual = list1[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMinusOperator_TestCount()
        {
            // arrange

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int value4 = 9;
            int value5 = 11;
            int expected = 3;
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();


            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list2.AddToList(value4);
            list2.AddToList(value4);
            list2.AddToList(value5);
            list1 = list1 - list2;
            

            int actual = list1.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
