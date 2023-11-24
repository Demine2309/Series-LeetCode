namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] list)
        {

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