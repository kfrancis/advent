using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day1Tests
    {
        [TestMethod]
        public void Day1_Example1()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result1 = problem.Solve("(())");
            int result2 = problem.Solve("()()");

            // Assert
            Assert.AreEqual(0, result1);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void Day1_Example2()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result1 = problem.Solve("(((");
            int result2 = problem.Solve("(()(()(");

            // Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void Day1_Example3()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result = problem.Solve("))(((((");

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Day1_Example4()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result1 = problem.Solve("())");
            int result2 = problem.Solve("))(");

            // Assert
            Assert.AreEqual(-1, result1);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void Day1_Example5()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result1 = problem.Solve(")))");
            int result2 = problem.Solve(")())())");

            // Assert
            Assert.AreEqual(-3, result1);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void Day1_Part2_Example1()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result = problem.SolvePart2(")");

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Day1_Part2_Example2()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result = problem.SolvePart2("()())");

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
