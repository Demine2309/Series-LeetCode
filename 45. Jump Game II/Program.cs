namespace SeriesLeetCode
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            //int target = nums.Length - 1;
            //int minCount = Int32.MaxValue;

            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //int count = 1;
            //int sum = nums[0];

            //for (int j = 1; j < nums.Length; j++)
            //{
            //    if (nums[j] == 0)
            //        continue;

            //    sum += nums[j];

            //    if (sum > target)
            //    {
            //        sum = nums[0];
            //        count = 1;
            //        continue;
            //    }
            //    else if (sum < target)
            //    {
            //        count++;
            //        continue;
            //    }
            //    else if (sum == target)
            //    {
            //        count++;
            //        break;
            //    }
            //}

            //if (minCount > count)
            //    minCount = count;
            //}

            //return minCount;

            int n = nums.Length;
            if (n == 1)
            {
                return 0;
            }

            int jumps = 0;
            int currentMaxReach = 0;
            int farthest = 0;

            for (int i = 0; i < n - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);

                if (i == currentMaxReach)
                {
                    jumps++;
                    currentMaxReach = farthest;
                }
            }

            return jumps;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 2, 3, 1, 1, 4 };
            int result = solution.Jump(nums);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [2,3,1,1,4]
    Output: 2
    Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.

 * Example 2:
    Input: nums = [2,3,0,1,4]
    Output: 2
 */