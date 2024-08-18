using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Principal;

namespace ExamTest
{
    [TestClass]
    public class UnitTestPermutations
    { 

        [TestMethod]
        [TestCategory("Your function should return: ['a']")]
        public void TestShufflingsCase1()
        {
           
            string input = "a"; 
            string[] expected = new string[] { "a" };
            string expectedText = "a";
            string[] actual = Exam2.Permutations.Shufflings(input);
            string actualText = string.Join(",",Exam2.Permutations.Shufflings(input));
            Assert.AreEqual(expectedText, actualText);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Your function should return ['ab', 'ba']")]
        public void TestShufflingsCase2()
        {
            string input = "ab";
            string[] expected = new string[] { "ab","ba" };
            string expectedText = "ab,ba";
            string[] actual = Exam2.Permutations.Shufflings(input);
            string actualText = string.Join(",", Exam2.Permutations.Shufflings(input));
            Assert.AreEqual(expectedText, actualText);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Your function should return ['abc','acb','bac','bca','cab','cba']")]
        public void TestShufflingsCase3()
        {
            string input = "abc";
            string[] expected = new string[] { "abc","acb","bac","bca","cab","cba" };
            string expectedText = "abc,acb,bac,bca,cab,cba";
            string[] actual = Exam2.Permutations.Shufflings(input);
            string actualText = string.Join(",", Exam2.Permutations.Shufflings(input));
            Assert.AreEqual(expectedText, actualText);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']")]
        public void TestShufflingsCase4()
        {
            string input = "aabb";
            string[] expected = new string[] { "aabb", "abab", "abba", "baab", "baba", "bbaa" };
            string expectedText = "aabb,abab,abba,baab,baba,bbaa";
            string[] actual = Exam2.Permutations.Shufflings(input);
            string actualText = string.Join(",", Exam2.Permutations.Shufflings(input));
            Assert.AreEqual(expectedText, actualText);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}