using System.Linq;

namespace SeriesLeetCode
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);

            int positiveIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[positiveIndex++] = nums[i];
                }
            }

            if (positiveIndex == 0 || nums[0] > 1)
            {
                return 1;
            }

            for (int i = 0; i < positiveIndex - 1; i++)
            {
                if (nums[i + 1] - nums[i] > 1)
                {
                    return nums[i] + 1;
                }
            }

            return nums[positiveIndex - 1] + 1;
        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 7, 8, 9, 11, 12 };

            int result = solution.FirstMissingPositive(nums);
            
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [1,2,0]
    Output: 3
    Explanation: The numbers in the range [1,2] are all in the array.

 * Example 2:
    Input: nums = [3,4,-1,1]
    Output: 2
    Explanation: 1 is in the array but 2 is missing.

 * Example 3:
    Input: nums = [7,8,9,11,12]
    Output: 1
    Explanation: The smallest positive integer 1 is missing.
 */