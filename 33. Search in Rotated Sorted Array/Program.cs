namespace SeriesLeetCode
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;

            int result = solution.Search(nums, target);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [4,5,6,7,0,1,2], target = 0
    Output: 4

 * Example 2:
    Input: nums = [4,5,6,7,0,1,2], target = 3
    Output: -1

 * Example 3:
    Input: nums = [1], target = 0
    Output: -1
 */