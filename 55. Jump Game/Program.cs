namespace SeriesLeetCode
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int n = nums.Length - 1;
            int currentIndex = 0;

            for (int i = 0; i <= currentIndex; i++)
            {
                int maxJump = nums[i];

                currentIndex = Math.Max(currentIndex, i + maxJump);

                if (currentIndex >= n)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 2,5,0,0 };

            bool result = solution.CanJump(nums);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [2,3,1,1,4]
    Output: true
    Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

 * Example 2:
    Input: nums = [3,2,1,0,4]
    Output: false
    Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
 */