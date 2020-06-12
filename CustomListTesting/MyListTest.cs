using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void AddOne_CheckCountOne()
        {
            //arange
            MyList<int> myList = new MyList<int>();
            int expected = 1;
            int actual;

            //act
            myList.Add(1);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwo_CheckCountTwo()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 2;
            int actual;

            myList.Add(1);
            myList.Add(2);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThree_CheckCountThree()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 3;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFour_CheckCountFour()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 4;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFive_CheckCountFive()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 5;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddOne_CheckIndexZero()
        {
            //arange
            MyList<int> myList = new MyList<int>();
            int expected = 1;
            int actual;

            //act
            myList.Add(1);
            actual = myList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwo_CheckIndexOne()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 2;
            int actual;

            myList.Add(1);
            myList.Add(2);
            actual = myList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThree_CheckIndexThree()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 3;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            actual = myList[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFive_CheckIndexFour()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 5;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            actual = myList[4];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_CheckCount_RemoveOneValue()
        {
            //arange
            MyList<int> myList = new MyList<int>();
            int expected = 2;
            int actual;

            //act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(2);
            actual = myList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CheckIndex_RemoveMiddleValue()
        {
            //arange

            MyList<int> myList = new MyList<int>();
            int expected = 6;
            int actual;

            //act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.add(9);
            myList.Add(10);
            myList.Remove(5);
            actual = myList[6];

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Remove_CheckCount_RemoveAllValues()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 0;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList.Remove(1);
            myList.Remove(2);
            myList.Remove(3);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        public void ToString_Check_ListOfStrings()
        {
            //arange
            MyList<string> myList = new MyList<string>();
            string expected = "Hello";
            string actual;

            //act
            myList.Add("H");
            myList.Add("E");
            myList.Add("L");
            myList.Add("L");
            myList.Add("O");

            actual = myList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_One_CheckCapacity()
        {
            //arange
            MyList<string> words = new MyList<string>();
            int expected = 4;
            int actual;

            //act
            words.Add("My");
            actual = words.Capacity;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_Two_CheckCapacity()
        {
            MyList<string> words = new MyList<string>();
            int expected = 4;
            int actual;

            //act
            words.Add("My");
            words.Add("name");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_Three_CheckCapacity()
        {
            MyList<string> words = new MyList<string>();
            int expected = 4;
            int actual;

            words.Add("My");
            words.Add("name");
            words.Add("is");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Four_CheckCapacity()
        {
            MyList<string> words = new MyList<string>();
            int expected = 4;
            int actual;

            words.Add("My");
            words.Add("name");
            words.Add("is");
            words.Add("Jorge");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_Five_CheckIndex()
        {
            MyList<int> myList = new MyList<int>();
            string expected = null;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            myList.Remove(5);
            myList.Remove(4);
            myList.Remove(3);
            myList.Remove(2);
            myList.Remove(1);

            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_OneNumber_ToString()
        {
            MyList<int> myList = new MyList<int>();
            string expected = "1";
            string actual;

            myList.Add(1);

            actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TwoNumbers_ToString()
        {
            MyList<int> myList = new MyList<int>();
            string expected = "2";
            string actual;

            myList.Add(1);
            myList.Add(2);

            actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_OneWord_ToString()
        {
            MyList<string> words = new MyList<string>();
            string expected = "Coding";
            string actual;

            words.Add("Coding");

            actual = words.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TwoWords_ToString()
        {
            MyList<string> words = new MyList<string>();
            string expected = "Coding is";
            string actual;

            words.Add("Coding");
            words.Add("is");

            actual = words.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ThreeWords_ToString()
        {
            MyList<string> words = new MyList<string>();
            string expected = "Coding is cool!";
            string actual;

            words.Add("Coding");
            words.Add("is");
            words.Add("cool!");

            actual = words.ToString();

            Assert.AreEqual(expected, actual);
        }

    }
}
}
