using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBasicPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ChkPalindrome("Raj");
        }

        //To check even or odd number
        public bool EvenOrOdd(int num)
        {
            bool EoOresult = num % 2 == 0 ? true : false;
            return EoOresult;
        }

        //To check positive or negative number 
        public bool PosOrNeg(int num)
        {
            bool PoNresult = num < 0 ? false : true;
            return PoNresult;
        }

        //To check sum of natural numbers
        public int SumOfNatNum(int num)
        {
            int sum = (num * (num + 1)) / 2;
            return sum;
        }

        //To check sum of natural number within a range
        public int SumOfNatNum(int inum, int fNum)
        {
            int sum = 0;
            for (int i = inum; i <= fNum; i++)
            {
                sum += i;
            }
            return sum;
        }

        //Greatest of two numbers 
        public int GOfTwoNum(int fNum, int sNum)
        {
            int result = fNum > sNum ? fNum : sNum;
            return result;
        }

        //Greatest of three numbers
        public int GOfThreeNum(int fNum, int sNum, int tNum)
        {
            int result = tNum > (fNum > sNum ? fNum : sNum) ? tNum : (fNum > sNum ? fNum : sNum);
            return result;
        }

        //Checking the given year is leap year or not 
        public bool ChkLeapOrNot(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else
                return false;
        }

        //Check Prime Number
        public bool ChkPrime(int pNum)
        {
            int count = 0;
            if (pNum == 1)
            {
                return false;
            }
            else if (pNum == 2)
            {
                return true;

            }
            else
            {
                for (int i = 2; i <= pNum; i++)
                {
                    if (pNum % i == 0)
                        count++;
                }
                if (count == 1)
                    return true;
                else
                    return false;
            }
        }

        //Printing Sum of digits of a number
        public int SumOfDigits(int digit)
        {
            int sum = 0;
            while (digit != 0)
            {
                int lastNum = digit % 10;
                sum += lastNum;
                digit /= 10;
            }
            return sum;
        }
        //Printing Reverse of a number and string
        public string ReverseNum(string numR)
        {
            // Converting string to character array
            char[] charNum = numR.ToCharArray();
            // Declaring an empty string
            string tempStr = string.Empty;
            for (int i = charNum.Length - 1; i > -1; i--)
            {
                // Append each character to the temp string.
                tempStr += charNum[i];
            }
            return tempStr;
        }

        //Checking a given number is palindrome or not
        public bool ChkPalindrome(string palStr)
        {
            // Converting string to character array
            char[] charStr = palStr.ToCharArray();
            // Declaring an empty string
            string tempStr = string.Empty;
            for (int i = charStr.Length-1; i >= 0; i--)
            {
                // Append each character to the temp string.
                tempStr += charStr[i];
            }
            if (tempStr.Equals(palStr))
                return true;
            else
                return false;
        }
    }
}
