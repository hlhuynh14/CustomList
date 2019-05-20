using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTestSort
    {
        CustomList<int> list1;
        CustomList<string> list2;

        [TestMethod]
        public void TestSort_TestIndex1()
        {
            // arrange

            int value1 = 11;
            int value2 = 9;
            int value3 = 7;
            int value4 = 5;
            int value5 = 3;
            int expected = 11;
            list1 = new CustomList<int>();



            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list1.AddToList(value4);
            list1.AddToList(value5);
            list1.Sort();


            int actual = list1[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSort_TestIndex2()
        {
            // arrange

            int value1 = 11;
            int value2 = 9;
            int value3 = 7;
            int value4 = 5;
            int value5 = 3;
            int expected = 3;
            list1 = new CustomList<int>();



            // act
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list1.AddToList(value4);
            list1.AddToList(value5);
            list1.Sort();


            int actual = list1[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSort_TestIndex3()
        {
            // arrange

            string value1 = "kurt";
            string value2 = "bella";
            string value3 = "abe";
            string value4 = "bill";
            string value5 = "aang";
            string expected = "aang";
            list2 = new CustomList<string>();



            // act
            list2.AddToList(value1);
            list2.AddToList(value2);
            list2.AddToList(value3);
            list2.AddToList(value4);
            list2.AddToList(value5);
            list2.Sort();


            string actual = list2[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSort_TestIndex4()
        {
            // arrange

            string value1 = "kurt";
            string value2 = "bella";
            string value3 = "abe";
            string value4 = "bill";
            string value5 = "aang";
            string expected = "kurt";
            list2 = new CustomList<string>();



            // act
            list2.AddToList(value1);
            list2.AddToList(value2);
            list2.AddToList(value3);
            list2.AddToList(value4);
            list2.AddToList(value5);
            list2.Sort();


            string actual = list2[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

