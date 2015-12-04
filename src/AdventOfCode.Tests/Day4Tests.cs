using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day4Tests
    {
        [TestMethod]
        public void Day4_Part1_Example1()
        {
            // Arrange
            var problem = new day4();

            // Act
            int result = problem.SolvePart1("abcdef");

            // Assert
            Assert.AreEqual(609043, result);
        }

        [TestMethod]
        public void Day4_Part1_Example2()
        {
            // Arrange
            var problem = new day4();

            // Act
            int result = problem.SolvePart1("pqrstuv");

            // Assert
            Assert.AreEqual(1048970, result);
        }
    }
}
