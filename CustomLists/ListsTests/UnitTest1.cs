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
        public void addElement_CheckElementIsntAddedToFront_String()
        {
            //Arrange
            CustomLists<string> words = new CustomLists<string>() { "hello", "world", "World" };
            words.Add("hello");
            words.Add("world");
            words.Add("World");
            string word = "Hello";
            //Act
            words.Add(word);
            //Assert
            Assert.AreNotEqual(words.ElementAt(0), word);
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
            Assert.AreEqual(words.ElementAt(words.Count - 1), word);
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
            Assert.IsTrue(bools.ElementAt(0));
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
            Assert.IsFalse(bools.ElementAt(bools.Count - 1));
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
            //Act
            nums.Remove(removeInt);
            //Assert
            bool removed = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums.ElementAt(i) == removeInt)
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
            CustomLists<int> nums = new CustomLists<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(2);
            nums.Add(3);
            int removeInt = 2;
            //Act
            nums.Remove(removeInt);
            //Assert
            bool removed = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums.ElementAt(i) == removeInt)
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
                if (words.ElementAt(i) == removeWord)
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
                if (words.ElementAt(i) == removeWord)
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
                if (bools.ElementAt(i) == removeBool)
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
                if (bools.ElementAt(i) == removeBool)
                {
                    removed = false;
                }
            }
            Assert.IsFalse(removed);
        }
        public void zipLists_Int()
        {
            //Arrange
            CustomLists<int> odds = new CustomLists<int>();
            odds.Add(1);
            odds.Add(3);
            odds.Add(5);
            CustomLists<int> evens = new CustomLists<int>();
            evens.Add(2);
            evens.Add(4);
            evens.Add(6);
            //Act
            CustomLists<int> nums = odds.ZipperLists(evens);
            //Assert
            
        }
    }
}
