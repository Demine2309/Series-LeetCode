using System.Collections.Generic;

namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);

            List<IList<int>> result = new List<IList<int>>();
            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];

            Permute(nums, used, current, result);

            return result;
        }

        private void Permute(int[] nums, bool[] used, List<int> current, List<IList<int>> result)
        {
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                // Skip duplicates
                if (used[i] || (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]))
                    continue;

                used[i] = true;
                current.Add(nums[i]);
                Permute(nums, used, current, result);
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }

     
        public void Print(IList<IList<int>> result)
        {
            foreach (var element in result)
            {
                Console.Write("[");
                Console.Write(String.Join(", ", element));
                Console.Write("] ");

                Console.WriteLine();
            }
        }

        class MainClass
        {
            static void Main(string[] args)
            {
                Solution solution = new Solution();

                int[] nums = { 2, 2, 1, 1};
                IList<IList<int>> result = solution.PermuteUnique(nums);

                solution.Print(result);
            }
        }
    }
}

/*
 * Example 1:
    Input: nums = [1,1,2]
    Output:
    [[1,1,2],
     [1,2,1],
     [2,1,1]]

 * Example 2:
    Input: nums = [1,2,3]
    Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 */