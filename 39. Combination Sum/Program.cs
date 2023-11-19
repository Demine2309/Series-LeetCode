namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> current = new List<int>();

            BackTrack(candidates, target, 0, current, result);

            return result;
        }

        private void BackTrack(int[] arr, int target, int start, IList<int> current, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = start; i < arr.Length; i++)
            {
                current.Add(arr[i]);
                BackTrack(arr, target - arr[i], i, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        public void Print(IList<IList<int>> result)
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

            int[] candidates = { 2, 3, 5 , 7};
            int target = 7;

            IList<IList<int>> result = solution.CombinationSum(candidates, target);

            solution.Print(result);
        }
    }
}

/*
 * Example 1:
    Input: candidates = [2,3,6,7], target = 7
    Output: [[2,2,3],[7]]
    Explanation:
    2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
    7 is a candidate, and 7 = 7.
    These are the only two combinations.

 * Example 2:
    Input: candidates = [2,3,5], target = 8
    Output: [[2,2,2,2],[2,3,3],[3,5]]

 * Example 3:
    Input: candidates = [2], target = 1
    Output: []
*/