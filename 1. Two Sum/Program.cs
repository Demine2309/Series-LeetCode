namespace SeriesLeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }

        public void Print(int[] result)
        {
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 3, 1, 3 };
            int target = 6;

            int[] result = solution.TwoSum(nums, target);

            solution.Print(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

 * Example 2:
    Input: nums = [3,2,4], target = 6
    Output: [1,2]

 * Example 3:
    Input: nums = [3,3], target = 6
    Output: [0,1]
 */