using AlaFibonacci.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;

namespace AlaFibonacci.Tests
{
    [TestClass]
    public class AlaFibonacciCalculatorTests
    {
        [TestMethod]
        public void Calculate_ValidArgument_ValidAnswer()
        {
            var answers = new Dictionary<uint, BigInteger>()
            {
                [0] = 1,
                [1] = 1,
                [2] = 2,
                [3] = 4,
                [4] = 7,
                [5] = 13,
                [6] = 24,
                [7] = 44,
                [8] = 81,
                [9] = 149,
                [10] = 274,
            };

            foreach (var answer in answers)
            {
                var calculated = AlaFibonacciCalculator.Calculate(answer.Key);

                Assert.AreEqual(calculated, answer.Value, 
                    $"Calculated value for index {answer.Key} MUST be {answer.Value}, while calculated is {calculated}.");
            }
        }
    }
}
