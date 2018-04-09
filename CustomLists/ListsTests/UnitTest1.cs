using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CustomLists;

namespace ListsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addElement_CheckElementIsntAddedToFront_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            int number = 0;
            //Act
            nums.Add(number);
            //Assert
            Assert.AreNotEqual(nums.ElementAt(0),number);
        }
        [TestMethod]
        public void addElement_CheckElementIsAddedToBack_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>() { 0, 1, 2};
            int number = 3;
            //Act
            nums.Add(number);
            //Assert
            Assert.AreEqual(nums[nums.Count - 1], number);
        }
        [TestMethod]
        public void addElement_CheckElementIsntAddedToFront_String()
        {
            //Arrange
            CustomLists<string> words = new CustomLists<string>() { "hello", "world", "World" };
            string word = "Hello";
            //Act
            words.Add(word);
            //Assert
            Assert.AreNotEqual(words[0], word);
        }
        [TestMethod]
        public void addElement_CheckElementIsAddedToBack_String()
        {
            //Arrange
            CustomLists<string> words = new CustomLists<string>() { "Hello", "hello", "world" };
            string word = "World";
            //Act
            words.Add(word);
            //Assert
            Assert.AreEqual(words[words.Count - 1], word);
        }
        [TestMethod]
        public void addElement_CheckElementIsntAddedToFront_Bool()
        {
            //Arrange
            CustomLists<bool> bools = new CustomLists<bool>() { true, false, true };
            bool isFalse = false;
            //Act
            bools.Add(isFalse);
            //Assert
            Assert.IsTrue(bools[0]);
        }
        [TestMethod]
        public void addElement_CheckElementIsAddedToBack_Bool()
        {
            //Arrange
            CustomLists<bool> bools = new CustomLists<bool>() { true, false, true };
            bool isFalse = false;
            //Act
            bools.Add(isFalse);
            //Assert
            Assert.IsFalse(bools[bools.Count - 1]);
        }
        [TestMethod]
        public void removeElement_CheckElementIsRemoved_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>() { 1, 2, 3 };
            int removeInt = 2;
            //Act
            nums.Remove(removeInt);
            //Assert
            bool removed = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == removeInt)
                {
                    removed = false;
                }
            }
            Assert.IsTrue(removed);
        }
        [TestMethod]
        public void removeElement_CheckIfAllElementsAreRemoved_Int()
        {
            //Arrange
            CustomLists<int> nums = new CustomLists<int>() { 1, 2, 2, 3 };
            int removeInt = 2;
            //Act
            nums.Remove(removeInt);
            //Assert
            bool removed = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == removeInt)
                {
                    removed = false;
                }
            }
            Assert.IsFalse(removed);
        }
        [TestMethod]
        public void removeElement_CheckElementIsRemoved_String()
        {
            //Arrange
            CustomLists<string> words = new CustomLists<string>() { "Hello", "hello", "world" };
            string removeWord = "hello";
            //Act
            words.Remove(removeWord);
            //Assert
            bool removed = true;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == removeWord)
                {
                    removed = false;
                }
            }
            Assert.IsTrue(removed);
        }
        [TestMethod]
        public void removeElement_CheckIfAllElementsAreRemoved_String()
        {
            //Arrange
            CustomLists<string> words = new CustomLists<string>() { "Hello", "hello", "hello", "world" };
            string removeWord = "hello";
            //Act
            words.Remove(removeWord);
            //Assert
            bool removed = true;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == removeWord)
                {
                    removed = false;
                }
            }
            Assert.IsFalse(removed);
        }
        [TestMethod]
        public void removeElement_CheckElementIsRemoved_Bool()
        {
            //Arrange
            CustomLists<bool> bools = new CustomLists<bool>() { true, false, true };
            bool removeBool = false;
            //Act
            bools.Remove(removeBool);
            //Assert
            bool removed = true;
            for (int i = 0; i < bools.Count; i++)
            {
                if (bools[i] == removeBool)
                {
                    removed = false;
                }
            }
            Assert.IsTrue(removed);
        }
        [TestMethod]
        public void removeElement_CheckIfAllElementsAreRemoved_Bool()
        {
            //Arrange
            CustomLists<bool> bools = new CustomLists<bool>() { true, false, false };
            bool removeBool = false;
            //Act
            bools.Remove(removeBool);
            //Assert
            bool removed = true;
            for (int i = 0; i < bools.Count; i++)
            {
                if (bools[i] == removeBool)
                {
                    removed = false;
                }
            }
            Assert.IsFalse(removed);
        }
        public void zipLists_Int()
        {
            //Arrange
            CustomLists<int> odds = new CustomLists<int>() { 1, 3, 5 };
            CustomLists<int> evens = new CustomLists<int>() { 2, 4, 6 };
            //Act
            CustomLists<int> nums = odds.ZipperLists(evens);
            //Assert
            
        }
    }
}
