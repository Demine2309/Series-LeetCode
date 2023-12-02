using System.Collections.Immutable;

namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            IList<string> element = new List<string>();
            IList<string> group = new List<string>();

            for (int i = 0; i < strs.Length;i++)
            {
                char[] c = strs[i].ToCharArray();

                Array.Sort(c);

                
                group.Add(c);
            }
        }

        public void Print(IList<IList<string>> result)
        {
            foreach (var combination in result)
            {
                Console.Write("[");
                foreach (var element in combination)
                {
                    Console.Write(element);
                    if (element != combination.Last())
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("] ");
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            IList<IList<string>> result = solution.GroupAnagrams(strs);

        }
    }
}

/*
 * Example 1:
    Input: strs = ["eat","tea","tan","ate","nat","bat"]
    Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

 * Example 2:
    Input: strs = [""]
    Output: [[""]]

 * Example 3:
    Input: strs = ["a"]
    Output: [["a"]]
 */