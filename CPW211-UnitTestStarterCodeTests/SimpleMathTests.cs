using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestCategory("Add")]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange 
            double expectedValue = num1 + num2;

            // Act
            double returnValue = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedValue, returnValue);
        }


        [TestMethod]
        [DataRow(2, .5)]
        [DataRow(100, .5)]
        [DataRow(-2, 5.5)]
        [DataRow(-50, -2.5)]
        [TestCategory("Multiply")]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange 
            double expectedValue = num1 * num2;

            // Act
            double returnValue = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedValue, returnValue);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(100)]
        [DataRow(-2)]
        [DataRow(-50)]
        [TestCategory("Divide")]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1)
        {
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, 0));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(2, .5)]
        [DataRow(100, .5)]
        [DataRow(-2, 5.5)]
        [DataRow(-50, 1000)]
        [TestCategory("Divide")]
        public void Divide_TwoValidNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange 
            double expectedValue = num1 / num2;

            // Act
            double returnValue = SimpleMath.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedValue, returnValue);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(2, 5)]
        [DataRow(-100, -105)]
        [DataRow(-1, 99.5)]
        [DataRow(-1000, .01)]
        [TestCategory("Subtract")]
        public void Subtract_TwoValidNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange 
            double expectedValue = num1 - num2;

            // Act
            double returnValue = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedValue, returnValue);
        }
    }
}