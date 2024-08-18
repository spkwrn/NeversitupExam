using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest
{
    [TestClass]
    public class UnitTestOddUnit
    {
        [TestMethod]
        [TestCategory("should return 7, because it occurs 1 time (which is odd)")]
        public void TestOddUnit1()
        {

            int[] input = new int[] { 7};
            int expected = 7;
          
            int actual = Exam2.OddUnit.FinfOddUnit(input);
           
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        [TestCategory("should return 0, because it occurs 1 time (which is odd)")]
        public void TestOddUnit2()
        {

            int[] input = new int[] { 0 };
            int expected = 0;

            int actual = Exam2.OddUnit.FinfOddUnit(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("[1,1,2] should return 2, because it occurs 1 time (which is odd).")]
        public void TestOddUnit3()
        {

            int[] input = new int[] { 1, 1, 2 };
            int expected = 2;

            int actual = Exam2.OddUnit.FinfOddUnit(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).")]
        public void TestOddUnit4()
        {

            int[] input = new int[] { 0, 1, 0, 1, 0 };
            int expected = 0;

            int actual = Exam2.OddUnit.FinfOddUnit(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).")]
        public void TestOddUnit5()
        {

            int[] input = new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
            int expected = 4;

            int actual = Exam2.OddUnit.FinfOddUnit(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
