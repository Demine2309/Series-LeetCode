namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);// Update code compared to problem 39

            IList<IList<int>> result = new List<IList<int>>();
            IList<int> current = new List<int>();

            BackTrack(candidates, target, 0, current, result);

            return result;
        }

        private void BackTrack(int[] arr, int target, int start, IList<int> current, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = start; i < arr.Length; i++)
            {
                // Update code compared to problem 39
                if (i > start && arr[i] == arr[i - 1])
                {
                    continue;
                }

                current.Add(arr[i]);
                BackTrack(arr, target - arr[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
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

    class MainCLass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;

            IList<IList<int>> result = solution.CombinationSum2(candidates, target);

            solution.Print(result);
        }
    }
}

/*
 * Example 1:
    Input: candidates = [10,1,2,7,6,1,5], target = 8
    Output: 
    [
    [1,1,6],
    [1,2,5],
    [1,7],
    [2,6]
    ]

 * Example 2:
    Input: candidates = [2,5,2,1,2], target = 5
    Output: 
    [
    [1,2,2],
    [5]
    ]
 */