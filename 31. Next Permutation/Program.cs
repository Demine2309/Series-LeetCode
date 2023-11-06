namespace SeriesLeetCode
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = nums.Length - 1;

                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }

                Swap(i, j, nums);
            }

            Reverse(nums, i + 1);
        }

        private void Swap(int i, int j, int[] arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void Reverse(int[] nums, int start)
        {
            int i = start;
            int j = nums.Length - 1;

            while (i < j)
            {
                Swap(i, j, nums);
                i++;
                j--;
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1, 2, 5, 4, 3 };

            solution.NextPermutation(nums);

            foreach (int i in nums)
            {
                Console.Write(i + "  ");
            }
        }
    }
}

/*
 * Example 1:
    Input: nums = [1,2,3]
    Output: [1,3,2]

 * Example 2:
    Input: nums = [3,2,1]
    Output: [1,2,3]

 * Example 3:
    Input: nums = [1,1,5]
    Output: [1,5,1]

 */