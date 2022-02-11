using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingBasicPrograms;
using System;

namespace MsTestingBasicProgram
{
    /// <summary>
    /// Testing basic programs
    /// </summary>
    [TestClass]
    public class TestingClass
    {
        Program program = null;

        [TestInitialize]
        public void SetUp()
        {
            program = new Program();
        }

        [TestCategory("Even Or Odd")]
        [TestMethod]
        ///Arange
        [DataRow(2,true)]
        [DataRow(3, false)]
        [DataRow(10, true)]
        [DataRow(13, false)]
        public void TestEvenOrOdd(int data, bool expected)
        {
            ///AAA methodology
    
            ///Act
            bool actual = program.EvenOrOdd(data);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Positive Or Negative")]
        [TestMethod]
        ///Arange
        [DataRow(2, true)]
        [DataRow(-3, false)]
        [DataRow(10, true)]
        [DataRow(-13, false)]
        ///Arange
        public void TestPosOrNeg(int data, bool expected)
        {
            ///AAA methodology

            ///Act
            bool actual = program.PosOrNeg(data);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Sum Of Natural Number")]
        [TestMethod]
        //Arrange
        [DataRow(10, 55)]
        [DataRow(11, 66)]
        [DataRow(5, 15)]
        [DataRow(15, 120)]
        public void TestSumOfNatNum(int data, int expected)
        {
            ///AAA methodology
            ///Act
            int actual = program.SumOfNatNum(data);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Sum Of Natural Number")]
        [TestMethod]
        ///Arange
        [DataRow(10, 15, 75)]
        [DataRow(10, 20, 165)]
        [DataRow(20, 25, 135)]
        [DataRow(5, 10, 45)]
        public void TestSumOfNatNumInRange(int numOne, int numTwo, int expected)
        {
            ///AAA methodology
  
            ///Act
            int actual = program.SumOfNatNum(numOne, numTwo);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Greatest Number")]
        [TestMethod]
        ///Arange
        [DataRow(10, 15, 15)]
        [DataRow(10, 20, 20)]
        [DataRow(20, 25, 25)]
        [DataRow(50, 10, 50)]
        public void TestGOfTwoNum(int numOne, int numTwo, int expected)
        {
            ///AAA methodology

            ///Act
            int actual = program.GOfTwoNum(numOne, numTwo);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Greatest Number")]
        [TestMethod]
        [DataRow(10, 15, 5, 15)]
        [DataRow(10, 20, 25, 25)]
        [DataRow(25, 20, 15, 25)]
        [DataRow(50, 10, 15, 50)]
        public void TestGOfThreeNum(int numOne, int numTwo, int numThree, int expected)
        {
            ///AAA methodology
            ///Arange
 
            ///Act
            int actual = program.GOfThreeNum(numOne, numTwo, numThree);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Leap Year")]
        [TestMethod]
        ///Arange
        [DataRow(2008, true)]
        [DataRow(1700, false)]
        [DataRow(2120, true)]
        [DataRow(2100, false)]
        public void TestChkLeapOrNot(int year , bool expected)
        {
            ///AAA methodology
            ///Arange

            ///Act
            bool actual = program.ChkLeapOrNot(year);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Prime Number")]
        [TestMethod]
        ///Arange
        [DataRow(13, true)]
        [DataRow(10, false)]
        [DataRow(31, true)]
        [DataRow(15, false)]
        public void TestChkPrime(int primNum, bool expected)
        {
            ///AAA methodology

            ///Act
            bool actual = program.ChkPrime(primNum);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Sum Of Digits")]
        [TestMethod]
        ///Arange
        [DataRow(13, 4)]
        [DataRow(13574, 20)]
        [DataRow(316, 10)]
        [DataRow(15, 6)]
        public void TestSumOfDigits(int sumNum, int expected)
        {
            ///AAA methodology;

            ///Act
            int actual = program.SumOfDigits(sumNum);

            ///Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Reverse String")]
        [TestMethod]
        [DataRow("13", "31")]
        [DataRow("13574", "47531")]
        [DataRow("316", "613")]
        [DataRow("15", "51")]
        public void TestReverseString(string revNum, string expectedValue)
        {
            ///AAA methodology

            ///Act
            string actual = program.ReverseNum(revNum);

            ///Assert
            Assert.AreEqual(expectedValue, actual);
        }


        [TestCategory("Palindrome")]
        [TestMethod]       
        ///Arange
        [DataRow("kook", true)]
        [DataRow("Raj", false)]
        [DataRow("MadaM", true)]
        [DataRow("Cook", false)]
        public void TestPalindrome(string palStr, bool expectedValue)
        {
            ///AAA methodology

            ///Act
            bool actual = program.ChkPalindrome(palStr);

            ///Assert
            Assert.AreEqual(expectedValue, actual);
        }
    }
}
