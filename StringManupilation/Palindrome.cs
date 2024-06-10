using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_DSA.StringManupilation
{
    public  class Palindrome
    {
        public bool isPalindrome(string str)
        {
            int left = 0;
            int right = str.Length-1;
            string leftindxString = "";
            string rightindxString = "";
            while (left < right)
            {
                leftindxString = leftindxString + str[left];
                rightindxString = rightindxString+str[right];
                left++;
                right--;
            }

            if(rightindxString.Equals(leftindxString))
            {
                return true;
            }
            else
            {
                return false;
            }
              }

    }
}
