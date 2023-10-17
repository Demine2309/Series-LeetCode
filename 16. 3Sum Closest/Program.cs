namespace SeriesLeetCode
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int n = nums.Length;
            int closestSum = Int32.MaxValue;

            for(int i = 0; i < n-2; i++)
            {
                int left = i + 1;
                int right = n - 1;

                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];
                    if (currentSum == target)
                        return target;

                    if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                        closestSum = currentSum;

                    if (currentSum > target)
                        right--;
                    else
                        left++;
                }
            }

            return closestSum;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { -1, 2, 1, -4 };
            int target = 1;

            int result = solution.ThreeSumClosest(nums, target);
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [-1,2,1,-4], target = 1
    Output: 2
    Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

 * Example 2:
    Input: nums = [0,0,0], target = 1
    Output: 0
    Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
 */