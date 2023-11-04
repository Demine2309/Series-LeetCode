namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


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