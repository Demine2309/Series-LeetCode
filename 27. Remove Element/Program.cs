namespace SeriesLeetcode
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var list = new List<int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    list.Add(nums[i]);
                }
            }

            int[] result = list.ToArray();
            Array.Copy(result, nums, result.Length);

            return result.Length;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            int k = solution.RemoveElement( nums, val);
            Console.WriteLine(k);
        }
    }
}

/*
Example 1:
Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2,_,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).

Example 2:
Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).
*/