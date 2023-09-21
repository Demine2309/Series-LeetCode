namespace SeriesLeetCode
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] expectArr = new int[m + n];

            int i = 0, j = 0, k = 0;

            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    expectArr[k] = nums1[i];
                    i++;
                }
                else
                {
                    expectArr[k] = nums2[j];
                    j++;
                }
                k++;
            }

            while (i < m)
            {
                expectArr[k] = nums1[i];
                i++;
                k++;
            }

            while (j < n)
            {
                expectArr[k] = nums2[j];
                j++;
                k++;
            }

            for(int a = 0; a < m + n; a++)
            {
                nums1[a] = expectArr[a];
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };

            solution.Merge(nums1, nums1.Length, nums2, nums2.Length);

            foreach(int i in nums1)
            {
                Console.Write(i + " ");
            }
        }
    }
}

/*
 * Example 1:
    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]
    Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
    The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

 * Example 2:
    Input: nums1 = [1], m = 1, nums2 = [], n = 0
    Output: [1]
    Explanation: The arrays we are merging are [1] and [].
    The result of the merge is [1].

 * Example 3:
    Input: nums1 = [0], m = 0, nums2 = [1], n = 1
    Output: [1]
    Explanation: The arrays we are merging are [] and [1].
    The result of the merge is [1].
    Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
 */
