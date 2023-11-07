namespace SeriesLeetCode
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            List<int> result = new List<int>();

            if (nums.Length == 0)
                return new int[] { -1, -1 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result.Add(i);
                }
            }

            if (result.Count == 0)
                return new int[] { -1, -1 };

            return new int[] { result[0], result[result.Count - 1] };
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1, 4 };
            int target = 4;

            int[] result = solution.SearchRange(nums, target);

            foreach (int i in result)
            {
                Console.Write(i + "  ");
            }
        }
    }
}

/*
 * Example 1:
    Input: nums = [5,7,7,8,8,10], target = 8
    Output: [3,4]

 * Example 2:
    Input: nums = [5,7,7,8,8,10], target = 6
    Output: [-1,-1]

 * Example 3:
    Input: nums = [], target = 0
    Output: [-1,-1]
 */