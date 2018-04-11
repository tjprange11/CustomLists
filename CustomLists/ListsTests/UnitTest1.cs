using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CustomLists;

namespace ListsTests
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void addElement_CheckElementIsAddedToBack_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>();
            nums.Add(0);
            nums.Add(1);
            nums.Add(2);
            int number = 3;
            //Act
            nums.Add(number);
            //Assert
            Assert.AreEqual(nums.ElementAt(nums.Count - 1), number);
        }

        [TestMethod]
        public void addElement_CheckCounter()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>() { 1, 2, 3 };
            int actual;
            int expected = 4;
            //Act
            nums.Add(4);
            actual = nums.Count;
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void removeElement_CheckElementIsRemoved_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            int removeInt = 2;
            int actual;
            int expected = 3;
            //Act
            nums.Remove(removeInt);
            actual = nums[1];
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void removeElement_CheckIfAllElementsAreRemoved_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>();
            nums.Add(1);
            nums.Add(4);
            nums.Add(3);
            nums.Add(4);
            int removeInt = 4;
            int actual;
            int expected = 4;
            //Act
            nums.Remove(removeInt);
            actual = nums[2];
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void removeElement_CheckCounter()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>() { 1, 2, 3 };
            int actual;
            int expected = 2;
            //Act
            nums.Remove(2);
            actual = nums.Count;
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void zipLists_TestIndex_1()
        {
            //Arrange
            CustomLists<int> odds = new CustomLists<int>() { 1, 3, 5 };
            CustomLists<int> evens = new CustomLists<int>() { 2, 4, 6, };
            int actual;
            int expected = 2;
            //Act
            CustomLists<int> newlist = odds.ZipLists(evens);
            actual = newlist[1];
            //Assert
            Assert.AreEqual(actual, expected);
            
        }

        [TestMethod]
        public void zipLists_TestIndex_2()
        {
            //Arrange
            CustomLists<int> odds = new CustomLists<int>() { 1, 3, 5 };
            CustomLists<int> evens = new CustomLists<int>() { 2, 4, 6, };
            int actual;
            int expected = 5;
            //Act
            CustomLists<int> newlist = odds.ZipLists(evens);
            actual = newlist[4];
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void zipLists_CheckCounter()
        {
            //Arrange
            CustomLists<int> odds = new CustomLists<int>() { 1, 3, 5 };
            CustomLists<int> evens = new CustomLists<int>() { 2, 4, 6, };
            int actual;
            int expected = 6;
            //Act
            CustomLists<int> newlist = odds.ZipLists(evens);
            actual = newlist.Count;
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void AddOpperatorOverload()
        {
            //Arrange
            CustomLists<int> list1 = new CustomLists<int>() { 1, 2, 3 };
            CustomLists<int> list2 = new CustomLists<int>() { 4, 5, 6 };
            CustomLists<int> actual;
            CustomLists<int> expected = new CustomLists<int>() { 1, 2, 3, 4, 5, 6, };
            //Act
            actual = list1 + list2;
            bool isTrue = true;
            for(int i = 0; i < expected.Count;i++)
            {
                if(actual[i] != expected[i])
                {
                    isTrue = false;
                }
            }
            //Assert
            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void SubtractOpperatorOverload()
        {
            //Arrange
            CustomLists<int> list1 = new CustomLists<int>() { 1, 2, 3, 4, 5, 6 };
            CustomLists<int> list2 = new CustomLists<int>() { 2, 4, 6 };
            CustomLists<int> actual;
            CustomLists<int> expected = new CustomLists<int>() { 1, 3, 5 };
            //Act
            actual = list1 - list2;
            bool isTrue = true;
            for (int i = 0; i < expected.Count; i++)
            {
                if (actual[i] != expected[i])
                {
                    isTrue = false;
                }
            }
            //Assert
            Assert.IsTrue(isTrue);
        }
    }
}
