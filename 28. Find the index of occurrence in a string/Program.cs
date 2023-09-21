namespace SeriesLeetcode
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            int result = -1;
            for(int i = 0; i < haystack.Length; i++)
            {
                int count = 0;
                int k = i;

                if (k > (haystack.Length - needle.Length))
                {
                    break;
                }

                for(int  j = 0; j < needle.Length; j++)
                {
                    if (haystack[k] == needle[j])
                    {
                        k++;
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if(count == needle.Length)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string haystack = "hello";
            string needle = "ll";
            
            int result = solution.StrStr(haystack, needle);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: haystack = "sadbutsad", needle = "sad"
    Output: 0
    Explanation: "sad" occurs at index 0 and 6.
    The first occurrence is at index 0, so we return 0.

 * Example 2:
    Input: haystack = "leetcode", needle = "leetcode"
    Output: -1
    Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/