using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTestToString
    {
        [TestMethod]
        public void ToString_CheckString()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            string expected = "5,6,7";


            // act
            myList.AddToList(value1);
            myList.AddToList(value2);
            myList.AddToList(value3);
            string myListString = myList.ToString();
            string actual = myListString;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] 
        public void ToString_CheckString2()
        {
            // arrange
            CustomList<string> myList = new CustomList<string>();
            string value1 = "hey";
            string value2 = "you";
            string value3 = "there";
            string expected = "hey,you,there";


            // act
            myList.AddToList(value1);
            myList.AddToList(value2);
            myList.AddToList(value3);
            string myListString = myList.ToString();
            string actual = myListString;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_CheckString3()
        {
            // arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "";



            // act
            string myListString = myList.ToString();
            string actual = myListString;

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
