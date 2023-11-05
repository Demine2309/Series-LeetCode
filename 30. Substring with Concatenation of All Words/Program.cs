using System;
using System.Collections.Generic;

namespace SeriesLeetCode
{

    // Way 1:
    //public class Solution
    //{
    //    public IList<int> FindSubstring(string s, string[] words)
    //    {
    //        int lengthOfWord = words[0].Length;
    //        int lengthOfSubstring = lengthOfWord * words.Length;
    //        IList<int> result = new List<int>();

    //        List<string> remainingWords = new List<string>(words);

    //        for (int i = 0; i <= s.Length - lengthOfSubstring; i++)
    //        {
    //            List<string> seenWords = new List<string>(remainingWords);

    //            int j;
    //            for (j = 0; j < words.Length; j++)
    //            {
    //                string currentWord = s.Substring(i + j * lengthOfWord, lengthOfWord);

    //                if (!seenWords.Contains(currentWord))
    //                {
    //                    break;
    //                }

    //                seenWords.Remove(currentWord);
    //            }

    //            if (j == words.Length)
    //            {
    //                result.Add(i);
    //            }
    //        }

    //        return result;
    //    }
    //}

    // Way 2:
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            int wordLength = words[0].Length;
            int substringLength = wordLength * words.Length;
            IList<int> result = new List<int>();

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                    wordCounts[word]++;
                else
                    wordCounts[word] = 1;
            }

            for (int i = 0; i <= s.Length - substringLength; i++)
            {
                Dictionary<string, int> seenWords = new Dictionary<string, int>(wordCounts);

                int j;
                for (j = 0; j < words.Length; j++)
                {
                    string currentWord = s.Substring(i + j * wordLength, wordLength);

                    if (!seenWords.ContainsKey(currentWord) || seenWords[currentWord] == 0)
                        break;

                    seenWords[currentWord]--;
                }

                if (j == words.Length)
                    result.Add(i);
            }

            return result;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "barfoofoobarthefoobarman";
            string[] words = { "bar", "foo", "the" };

            IList<int> result = solution.FindSubstring(s, words);

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}

/*
 * Example 1:
    Input: s = "barfoothefoobarman", words = ["foo","bar"]
    Output: [0,9]
    Explanation: Since words.length == 2 and words[i].length == 3, the concatenated substring has to be of length 6.
    The substring starting at 0 is "barfoo". It is the concatenation of ["bar","foo"] which is a permutation of words.
    The substring starting at 9 is "foobar". It is the concatenation of ["foo","bar"] which is a permutation of words.
    The output order does not matter. Returning [9,0] is fine too.

 * Example 2:
    Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]
    Output: []
    Explanation: Since words.length == 4 and words[i].length == 4, the concatenated substring has to be of length 16.
    There is no substring of length 16 in s that is equal to the concatenation of any permutation of words.
    We return an empty array.

 * Example 3:
    Input: s = "barfoofoobarthefoobarman", words = ["bar","foo","the"]
    Output: [6,9,12]
    Explanation: Since words.length == 3 and words[i].length == 3, the concatenated substring has to be of length 9.
    The substring starting at 6 is "foobarthe". It is the concatenation of ["foo","bar","the"] which is a permutation of words.
    The substring starting at 9 is "barthefoo". It is the concatenation of ["bar","the","foo"] which is a permutation of words.
    The substring starting at 12 is "thefoobar". It is the concatenation of ["the","foo","bar"] which is a permutation of words.
 */