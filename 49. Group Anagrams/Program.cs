namespace SeriesLeetCode
{
    public class Solution
    {
        #region Cách 1
        //public IList<IList<string>> GroupAnagrams(string[] strs)
        //{
        //    IList<IList<string>> result = new List<IList<string>>();

        //    IList<IList<string>> groups = new List<IList<string>>();

        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        string sortedStr = SortString(strs[i]);

        //        bool foundGroup = false;
        //        foreach (var group in groups)
        //        {
        //            if (group.Count > 0 && SortString(group[0]) == sortedStr)
        //            {
        //                group.Add(strs[i]);
        //                foundGroup = true;
        //                break;
        //            }
        //        }

        //        if (!foundGroup)
        //        {
        //            IList<string> newGroup = new List<string> { strs[i] };
        //            groups.Add(newGroup);
        //        }
        //    }

        //    foreach (var group in groups)
        //    {
        //        result.Add(group);
        //    }

        //    return result;
        //}

        //private string SortString(string input)
        //{
        //    char[] characters = input.ToCharArray();
        //    Array.Sort(characters);
        //    return new string(characters);
        //} 
        #endregion

        #region Cách 2
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> anagramGroups = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                string sortedStr = SortString(str);

                if (!anagramGroups.TryGetValue(sortedStr, out IList<string> group))
                {
                    group = new List<string>();
                    anagramGroups[sortedStr] = group;
                }

                group.Add(str);
            }

            return anagramGroups.Values.ToList();
        }

        private string SortString(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
        #endregion

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

            solution.Print(result);
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