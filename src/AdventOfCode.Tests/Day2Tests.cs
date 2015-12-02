using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day2Tests
    {
        [TestMethod]
        public void Day2_Part1_Example1()
        {
            // Arrange
            var problem = new day2();

            // Act
            int result = problem.SolvePart1("2x3x4");

            // Assert
            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void Day2_Part1_Example2()
        {
            // Arrange
            var problem = new day2();

            // Act
            int result = problem.SolvePart1("1x1x10");

            // Assert
            Assert.AreEqual(43, result);
        }

        [TestMethod]
        public void Day2_Part2_Example1()
        {
            // Arrange
            var problem = new day2();

            // Act
            int result = problem.SolvePart2("2x3x4");

            // Assert
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void Day2_Part2_Example2()
        {
            // Arrange
            var problem = new day2();

            // Act
            int result = problem.SolvePart2("1x1x10");

            // Assert
            Assert.AreEqual(14, result);
        }
    }
}
