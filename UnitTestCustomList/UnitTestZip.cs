using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTestZip
    {
        CustomList<int> list1;
        CustomList<int> list2;
        CustomList<string> list3;
        CustomList<string> list4;

        [TestMethod]
        public void ZipList_CheckListIndex1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 2;


            // act
            list1.AddToList(value1);
            list1.AddToList(value3);
            list1.AddToList(value5);
            list2.AddToList(value2);
            list2.AddToList(value4);
            list2.AddToList(value6);
            myList = list1.Zip(list2);
            int actual = myList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipList_CheckListIndex2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 6;


            // act
            list1.AddToList(value1);
            list1.AddToList(value3);
            list1.AddToList(value5);
            list2.AddToList(value2);
            list2.AddToList(value4);
            list2.AddToList(value6);
            myList = list1.Zip(list2);
            int actual = myList[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipList_CheckListIndex3()
        {
            // arrange
            CustomList<string> myList = new CustomList<string>();
            list3 = new CustomList<string>();
            list4 = new CustomList<string>();
            string value1 = "They";
            string value2 ="Make";
            string value3 = "Great";
            string value4 = "Tasting";
            string value5 = "Donuts";
            string value6 = "In";
            string value8 = "Here";

            string expected = "Here";


            // act
            list3.AddToList(value1);
            list3.AddToList(value3);
            list3.AddToList(value5);
            list4.AddToList(value2);
            list4.AddToList(value4);
            list4.AddToList(value6);
            list4.AddToList(value8);
            myList = list3.Zip(list4);
            string actual = myList[6];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipList_CheckCount1()
        {
            // arrange
            CustomList<string> myList = new CustomList<string>();
            list3 = new CustomList<string>();
            list4 = new CustomList<string>();
            string value1 = "They";
            string value2 = "Make";
            string value3 = "Great";
            string value4 = "Tasting";
            string value5 = "Donuts";
            string value6 = "In";
            string value8 = "Here";

            int expected = 7;


            // act
            list3.AddToList(value1);
            list3.AddToList(value3);
            list3.AddToList(value5);
            list4.AddToList(value2);
            list4.AddToList(value4);
            list4.AddToList(value6);
            list4.AddToList(value8);
            myList = list3.Zip(list4);
            int actual = myList.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipList_CheckCount2()
        {
            // arrange
            CustomList<string> myList = new CustomList<string>();
            list3 = new CustomList<string>();
            list4 = new CustomList<string>();
            string value1 = "They";
            string value2 = "Make";
            string value3 = "Great";
            string value4 = "Tasting";
            string value5 = "Donuts";
            string value6 = "In";
            string value7 = "What";
            string value8 = "Here";

            int expected = 8;


            // act
            list3.AddToList(value1);
            list3.AddToList(value3);
            list3.AddToList(value5);
            list3.AddToList(value7);
            list4.AddToList(value2);
            list4.AddToList(value4);
            list4.AddToList(value6);
            list4.AddToList(value8);
            myList = list3.Zip(list4);
            int actual = myList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipList_CheckCapacity1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;

            int expected = 4;


            // act
            list1.AddToList(value1);
            list1.AddToList(value3);
           
            list2.AddToList(value2);
            list2.AddToList(value4);
            myList = list1.Zip(list2);


            int actual = myList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipList_CheckCapacity2()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 8;


            // act
            list1.AddToList(value1);
            list1.AddToList(value3);
            list1.AddToList(value5);
            list2.AddToList(value2);
            list2.AddToList(value4);
            list1.AddToList(value6);
            myList = list1.Zip(list2);


            int actual = myList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}


