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
            List<int> nums2 = new List<int>() { 0, 1, 2, 3 };
            int number = 0;
            //Act
            nums.Add(number);
            //Assert
            Assert.AreNotEqual(nums[0],nums2[0]);
        }
        [TestMethod]
        public void addElement_CheckElementIsAddedToBack()
        {
            //Arrange
            List<int> nums = new List<int>() { 0, 1, 2};
            List<int> nums2 = new List<int>() { 0, 1, 2, 3 };
            int number = 3;
            //Act
            nums.Add(number);
            //Assert
            Assert.AreEqual(nums[0], nums2[0]);
        }
    }
}
