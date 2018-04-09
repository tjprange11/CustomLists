using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ListsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addElement_CheckElementIsntAddedToFront_Int()
        {
            //Arrange
            List<int> nums = new List<int>() { 1, 2, 3 };
            int number = 0;
            //Act
            nums.Add(number);
            //Assert
            Assert.AreNotEqual(nums[0],number);
        }
        [TestMethod]
        public void addElement_CheckElementIsAddedToBack_Int()
        {
            //Arrange
            List<int> nums = new List<int>() { 0, 1, 2};
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
            List<string> words = new List<string>() { "hello", "world", "World" };
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
            List<string> words = new List<string>() { "Hello", "hello", "world" };
            string word = "World";
            //Act
            words.Add(word);
            //Assert
            Assert.AreEqual(words[words.Count - 1], word);
        }
        [TestMethod]
        public void removeElement_CheckElementIsRemoved_Int()
        {
            //Arrange
            List<int> nums = new List<int>() { 1, 2, 3 };
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
            List<int> nums = new List<int>() { 1, 2, 2, 3 };
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
            List<string> words = new List<string>() { "Hello", "hello", "world" };
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
            List<string> words = new List<string>() { "Hello", "hello", "hello", "world" };
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
    }
}
