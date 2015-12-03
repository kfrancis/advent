using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        public void Day3_Part1_Example1()
        {
            // Arrange
            var problem = new day3();

            // Act
            int result = problem.SolvePart1(">");

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Day3_Part1_Example2()
        {
            // Arrange
            var problem = new day3();

            // Act
            int result = problem.SolvePart1("^>v<");

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Day3_Part1_Example3()
        {
            // Arrange
            var problem = new day3();

            // Act
            int result = problem.SolvePart1("^v^v^v^v^v");

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Day3_Part2_Example1()
        {
            // Arrange
            var problem = new day3();

            // Act
            int result = problem.SolvePart2("^v");

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Day3_Part2_Example2()
        {
            // Arrange
            var problem = new day3();

            // Act
            int result = problem.SolvePart2("^>v<");

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Day3_Part2_Example3()
        {
            // Arrange
            var problem = new day3();

            // Act
            int result = problem.SolvePart2("^v^v^v^v^v");

            // Assert
            Assert.AreEqual(11, result);
        }
    }
}
