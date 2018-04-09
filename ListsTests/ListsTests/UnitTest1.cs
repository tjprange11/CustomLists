using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ListsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addElement_CheckElementIsntAddedToFront()
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
        public void addElement_CheckElementIsAddedToBack()
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
        public void removeElement_CheckElementIsRemoved()
        {
            //Arrange
            List<int> nums = new List<int>() { 1, 2, 3 };
            //Act
            nums.Remove(2);
            //Assert
            bool removed = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 2)
                {
                    removed = false;
                }
            }
            Assert.IsTrue(removed);
        }
        [TestMethod]
        public void removeElement_CheckIfAllElementsAreRemoved()
        {
            //Arrange
            List<int> nums = new List<int>() { 1, 2, 2, 3 };
            //Act
            nums.Remove(2);
            //Assert
            bool removed = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 2)
                {
                    removed = false;
                }
            }
            Assert.IsFalse(removed);
        }
    }
}
