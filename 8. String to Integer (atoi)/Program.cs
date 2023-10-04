using System.Text;

namespace SeriesLeetCode
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            int index = 0;
            int sign = 1;
            long result = 0;

            while(index < s.Length && s[index] == ' ')
            {
                index++;
            }

            if(index < s.Length && (s[index] == '-' || s[index] == '+'))
            {
                sign = s[index] == '-' ? -1 : 1;
                index++;
            }

            while (index < s.Length && char.IsDigit(s[index]))
            {
                result = result * 10 + (s[index] - '0');

                if(result * sign > int.MaxValue)
                    return int.MaxValue;
                else if( result * sign < int.MinValue)
                    return int.MinValue;

                index++;
            }

            result *= sign;

            return (int)result;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "-   42";
            int result = solution.MyAtoi(s);
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "42"
    Output: 42
    Explanation: The underlined characters are what is read in, the caret is the current reader position.
    Step 1: "42" (no characters read because there is no leading whitespace)
             ^
    Step 2: "42" (no characters read because there is neither a '-' nor '+')
             ^
    Step 3: "42" ("42" is read in)
               ^
    The parsed integer is 42.
    Since 42 is in the range [-231, 231 - 1], the final result is 42.

* Example 2:
    Input: s = "   -42"
    Output: -42
    Explanation:
    Step 1: "   -42" (leading whitespace is read and ignored)
                ^
    Step 2: "   -42" ('-' is read, so the result should be negative)
                 ^
    Step 3: "   -42" ("42" is read in)
                   ^
    The parsed integer is -42.
    Since -42 is in the range [-231, 231 - 1], the final result is -42.

* Example 3:
    Input: s = "4193 with words"
    Output: 4193
    Explanation:
    Step 1: "4193 with words" (no characters read because there is no leading whitespace)
             ^
    Step 2: "4193 with words" (no characters read because there is neither a '-' nor '+')
             ^
    Step 3: "4193 with words" ("4193" is read in; reading stops because the next character is a non-digit)
                 ^
    The parsed integer is 4193.
    Since 4193 is in the range [-231, 231 - 1], the final result is 4193.
 */