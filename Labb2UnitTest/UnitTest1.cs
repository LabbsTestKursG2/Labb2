using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labb2TestKurs;
using System.Text.RegularExpressions;

namespace Labb2UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StrCount()
        {
            Solution sl = new Solution();
            string str = "string";
            var result = sl.StrCount(str);
            Assert.IsTrue(result.Length == str.Length);

        }

        [TestMethod]
        public void StrTypeIsNumber()
        {
            Solution sl = new Solution();
            string n = "2";
            var result = sl.StrType(n);
            Regex ex = new Regex(@"[0-9]+$");

            Assert.IsTrue(ex.IsMatch(result));

        }

        [TestMethod]
        public void StrTypeIsWord()
        {
            Solution sl = new Solution();
            string n = "abc";
            var result = sl.StrType(n);
            Regex ex = new Regex(@"[A-Za-z]+$");

            Assert.IsTrue(ex.IsMatch(result));

        }

        [TestMethod]
        public void isNone()
        {
            Solution sl = new Solution();
            string n = "abc, defghi, jklmn";
            var result = sl.StrType(n);
            Regex ex = new Regex(@"^([A-Za-z0-9]\s?)+([,]\s?([A-Za-z0-9]\s?)+)*$");

            Assert.IsTrue(ex.IsMatch(result));

        }

        [TestMethod]
        public void NextPalindrome()
        {
            Solution sl = new Solution();

            int num1 = 123;

            int num2 = 321;

            var result = sl.NextPalindrome(num1);

            Assert.AreEqual(num2, result);
        }

        [TestMethod]
        public void NextPrime()
        {
            Solution sl = new Solution();

            int num1 = 11;

            int[] primes = { 13, 17, 19 };

            var result = sl.NextPrime(num1);

            Assert.AreEqual(primes, result);
        }


    }
}
