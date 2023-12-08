namespace SeriesLeetCode
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            if(nums.Length == 0) return new int[0];

            List<int> result = new List<int>();
            int currentSum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                result.Add(currentSum);
            }

            return result.ToArray();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1 };
            int[] result = solution.RunningSum(nums);

            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}

/*
 * Example 1:
    Input: nums = [1,2,3,4]
    Output: [1,3,6,10]
    Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

 * Example 2:
    Input: nums = [1,1,1,1,1]
    Output: [1,2,3,4,5]
    Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

 * Example 3:
    Input: nums = [3,1,2,10,1]
    Output: [3,4,6,16,17]
 */