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

        [TestMethod]
        [Ignore]
        public void ZipList_CheckListIndex1()
        {
            // arrange
            CustomList<int> myList = new CustomList<int>();
            list1 = new CustomList<int>();
            list2 = new CustomList<int>();
            int expected = 2;


            // act
            
            int actual = myList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
