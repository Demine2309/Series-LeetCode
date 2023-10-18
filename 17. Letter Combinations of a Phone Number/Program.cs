namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        { 
            IList<string> combinations = new List<string>();

            if(string.IsNullOrEmpty(digits))
                return combinations;

            combinations.Add("");

            foreach(char digit in digits)
            {
                string letters = GetLetters(digit);

                List<string> newCombinations = new List<string>();

                foreach(string combination in combinations)
                {
                    foreach(char letter in letters)
                        newCombinations.Add(combination + letter);
                }

                combinations = newCombinations;
            }

            return combinations;
        }

        private string GetLetters(char digit)
        {
            switch (digit)
            {
                case '2': return "abc";
                case '3': return "def";
                case '4': return "ghi";
                case '5': return "jkl";
                case '6': return "mno";
                case '7': return "pqrs";
                case '8': return "tuv";
                case '9': return "wxyz";
                default: return "";
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string digits = "234";
            IList<string> result = solution.LetterCombinations(digits);

            foreach (string r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}

/*
 * Example 1:
    Input: digits = "23"
    Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

 * Example 2:
    Input: digits = ""
    Output: []

 * Example 3:
    Input: digits = "2"
    Output: ["a","b","c"]
 */