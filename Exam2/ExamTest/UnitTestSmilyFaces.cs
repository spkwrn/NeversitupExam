using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest
{
    [TestClass]
    public class UnitTestSmilyFaces
    {
        [TestMethod]
        [TestCategory("([':)', ';(', ';}', ':-D']);  // should return 2")]
        public void TestOddUnit1()
        {

            string[] input = new string[] { ":)", ";(", ";}", ":-D" };
            int expected = 2;
          
            int actual = Exam2.SmilyFaces.CountSmilyFaces(input);
           
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        [TestCategory("([';D', ':-(', ':-)', ';~)']);     // should return 3")]
        public void TestOddUnit2()
        {

            string[] input = new string[] { ";D", ":-(", ":-)", ";~)" };
            int expected = 3;

            int actual = Exam2.SmilyFaces.CountSmilyFaces(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("([';]', ':[', ';*', ':$', ';-D']); // should return 1")]
        public void TestOddUnit3()
        {

            string[] input = new string[] { ";]", ":[", ";* ", ":$", ";-D" };
            int expected = 1;

            int actual = Exam2.SmilyFaces.CountSmilyFaces(input);

            Assert.AreEqual(expected, actual);
        }
        
    }
}
