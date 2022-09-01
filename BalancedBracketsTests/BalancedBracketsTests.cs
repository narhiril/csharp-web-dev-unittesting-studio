using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void FalseOnOnlyOpenBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void FalseOnOnlyCloseBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void FalseOnDoubleOpenBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }

        [TestMethod]
        public void FalseOnDoubleCloseBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }

        [TestMethod]
        public void FalseOnNestedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void FalseOnBracketsOutOfOrder()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launc][code"));
        }

        [TestMethod]
        public void FalseOnBracketsOutOfOrderNonConsecutive()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]launchcode["));
        }

        [TestMethod]
        public void TrueOnBracketsInOrderNonConsecutive()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCo[de]"));
        }

        [TestMethod]
        public void FalseOnMixOfMatchedAndMismatched()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[launch]c[]de]["));
        }

        [TestMethod]
        public void TrueOnMultipleCorrectPairings()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        [TestMethod]
        public void TrueOnMultipleCorrectPairingsNonConsecutive()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code[][]"));
        }

        [TestMethod]
        public void ConsistentAcrossMultipleCalls()
        {
            string str = "[][]";
            bool firstCall = BalancedBrackets.HasBalancedBrackets(str);
            bool secondCall = BalancedBrackets.HasBalancedBrackets(str);
            Assert.AreEqual(firstCall, secondCall);
        }


    }
}
