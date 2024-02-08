﻿namespace SeriesLeetCode
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
              
            string strX = x.ToString();

            char[] charArray = strX.ToCharArray();

            Array.Reverse(charArray);

            string reversedStrX = new string(charArray);

            return strX.Equals(reversedStrX);
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int x = 121;

            bool isPalindrome = solution.IsPalindrome(x);

            Console.WriteLine(isPalindrome);
        }
    }
}

/*
 * Example 1:
    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.

 * Example 2:
    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

 * Example 3:
    Input: x = 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 */