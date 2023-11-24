using System.Collections.Generic;

namespace SeriesLeetCode
{
    //public class Solution
    //{
    //    public IList<IList<int>> Permute(int[] list)
    //    {
    //        IList<IList<int>> result = new List<IList<int>>();
    //        IList<int> newElement = ConvertArrayToList(list);

    //        int numberOfResult = list.Length;

    //        result.Add(newElement);

    //        for (int  i = 1; i <= numberOfResult; i++)
    //        {
    //            newElement = NextPermutation(list);

    //            result.Add(newElement);
    //        }

    //        return result;
    //    }

    //    private IList<int> NextPermutation(int[] nums)
    //    {
    //        int i = nums.Length - 2;
    //        while (i >= 0 && nums[i] >= nums[i + 1])
    //        {
    //            i--;
    //        }

    //        if (i >= 0)
    //        {
    //            int j = nums.Length - 1;

    //            while (j >= 0 && nums[j] <= nums[i])
    //            {
    //                j--;
    //            }

    //            Swap(i, j, nums);
    //        }

    //        Reverse(nums, i + 1);

    //        return ConvertArrayToList(nums);
    //    }

    //    private IList<int> ConvertArrayToList(int[] arr)
    //    {
    //        IList<int> list = new List<int>();

    //        foreach (int element in arr)
    //        {
    //            list.Add(element);
    //        }

    //        return list;
    //    }

    //    private void Swap(int i, int j, int[] arr)
    //    {
    //        int temp = arr[i];
    //        arr[i] = arr[j];
    //        arr[j] = temp;
    //    }

    //    private void Reverse(int[] nums, int start)
    //    {
    //        int i = start;
    //        int j = nums.Length - 1;

    //        while (i < j)
    //        {
    //            Swap(i, j, nums);
    //            i++;
    //            j--;
    //        }
    //    }

    //    private int Factorial(int n)
    //    {
    //        if (n == 0 || n == 1)
    //            return 1;
    //        else
    //            return n * Factorial(n - 1);
    //    }

    //    public void Print(IList<IList<int>> result)
    //    {
    //        foreach (var combination in result)
    //        {
    //            Console.Write("[");
    //            foreach (var element in combination)
    //            {
    //                Console.Write(element);
    //                if (element != combination.Last())
    //                {
    //                    Console.Write(",");
    //                }
    //            }
    //            Console.Write("] ");
    //        }
    //    }
    //}


    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> current = new List<int>();
            bool[] used = new bool[nums.Length];

            GeneratePermutations(nums, result, current, used);

            return result;
        }

        private void GeneratePermutations(int[] nums, IList<IList<int>> result, IList<int> current, bool[] used)
        {
            if (current.Count == nums.Length)
            {
                // Add a copy of the current permutation to the result
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!used[i])
                {
                    // Include the current number in the permutation
                    current.Add(nums[i]);
                    used[i] = true;

                    // Recursively generate permutations for the remaining numbers
                    GeneratePermutations(nums, result, current, used);

                    // Backtrack: remove the last added number and mark it as unused
                    current.RemoveAt(current.Count - 1);
                    used[i] = false;
                }
            }
        }

        public void Print(IList<IList<int>> result)
        {
            foreach (var combination in result)
            {
                Console.Write("[");
                foreach (var element in combination)
                {
                    Console.Write(element);
                    if (element != combination.Last())
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("] ");
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1, 2, 3 };
            IList<IList<int>> result = solution.Permute(nums);

            solution.Print(result);
        }
    }
}

/*
 * Example 1:
    Input: nums = [1,2,3]
    Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

 * Example 2:
    Input: nums = [0,1]
    Output: [[0,1],[1,0]]

 * Example 3:
    Input: nums = [1]
    Output: [[1]]
 */