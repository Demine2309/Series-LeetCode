using System.Collections.Generic;

namespace SeriesLeetCode
{
    #region My way
    public class Solution
    {
        public IList<IList<int>> Permute(int[] list)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> newElement = ConvertArrayToList(list);

            int numberOfResult = Factorial(list.Length);

            result.Add(newElement);

            for (int i = 1; i <= numberOfResult - 1; i++)
            {
                newElement = NextPermutation(list);

                result.Add(newElement);
            }

            return result;
        }

        private IList<int> NextPermutation(int[] arr)
        {
            int i = arr.Length - 2;
            while (i >= 0 && arr[i] >= arr[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = arr.Length - 1;

                while (j >= 0 && arr[j] <= arr[i])
                {
                    j--;
                }

                Swap(i, j, arr);
            }

            Reverse(arr, i + 1);

            return ConvertArrayToList(arr);
        }

        private IList<int> ConvertArrayToList(int[] arr)
        {
            IList<int> list = new List<int>();

            foreach (int element in arr)
            {
                list.Add(element);
            }

            return list;
        }

        private void Swap(int i, int j, int[] arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void Reverse(int[] arr, int start)
        {
            int i = start;
            int j = arr.Length - 1;

            while (i < j)
            {
                Swap(i, j, arr);
                i++;
                j--;
            }
        }

        private int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
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
    #endregion

    #region Other way
    //public class Solution
    //{
    //    public IList<IList<int>> Permute(int[] nums)
    //    {
    //        IList<IList<int>> result = new List<IList<int>>();
    //        IList<int> current = new List<int>();
    //        bool[] used = new bool[nums.Length];

    //        GeneratePermutations(nums, result, current, used);

    //        return result;
    //    }

    //    private void GeneratePermutations(int[] nums, IList<IList<int>> result, IList<int> current, bool[] used)
    //    {
    //        if (current.Count == nums.Length)
    //        {
    //            result.Add(new List<int>(current));
    //            return;
    //        }

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (!used[i])
    //            {
    //                current.Add(nums[i]);
    //                used[i] = true;

    //                GeneratePermutations(nums, result, current, used);

    //                current.RemoveAt(current.Count - 1);
    //                used[i] = false;
    //            }
    //        }
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
    #endregion


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