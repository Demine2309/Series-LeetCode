namespace SeriesLeetCode
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Merge the two arrays into one sorted array
            List<int> merged = new List<int>();
            int i = 0, j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    merged.Add(nums1[i]);
                    i++;
                }
                else
                {
                    merged.Add(nums2[j]);
                    j++;
                }
            }

            while (i < nums1.Length)
            {
                merged.Add(nums1[i]);
                i++;
            }

            while (j < nums2.Length)
            {
                merged.Add(nums2[j]);
                j++;
            }

            // Calculate the median
            int totalLen = merged.Count;
            int mid = totalLen / 2;

            if (totalLen % 2 == 0)
            {
                return (merged[mid - 1] + merged[mid]) / 2.0;
            }
            else
            {
                return merged[mid];
            }
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };

            double result = solution.FindMedianSortedArrays(nums1, nums2);

            Console.WriteLine(result);
        }
    }
}

/*
* Example 1:
    Input: nums1 = [1, 3], nums2 = [2]
    Output: 2.00000
    Explanation: merged array = [1, 2, 3] and median is 2.

* Example 2:
    Input: nums1 = [1, 2], nums2 = [3, 4]
    Output: 2.50000
    Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.
*/