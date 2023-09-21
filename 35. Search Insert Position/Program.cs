namespace SeriesLeetCode
{
    public class Solution
    {
        #region My Solution
        //public int SearchInsert(int[] nums, int target)
        //{
        //    int result = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (target <= nums[i])
        //        {
        //            result = i;
        //            break;
        //        }
        //        else
        //            result = nums.Length;
        //    }

        //    return result;
        //}
        #endregion

        #region Best solution
        public int SearchInsert(int[] nums, int target)
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
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            // If the target is not found, 'left' will be the index where it should be inserted
            return left;
        }
        #endregion

        public class MainClass
        {
            static void Main(string[] args)
            {
                Solution solution = new Solution();

                int[] nums = { 1, 3, 5, 6 };
                int target = 5;

                int result = solution.SearchInsert(nums, target);
                Console.WriteLine(result);
            }
        }
    }
}
/*
 * Example 1:
    Input: nums = [1,3,5,6], target = 5
    Output: 2

 * Example 2:
    Input: nums = [1,3,5,6], target = 2
    Output: 1

 * Example 3:
    Input: nums = [1,3,5,6], target = 7
    Output: 4
 */