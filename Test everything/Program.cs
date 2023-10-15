class Program
{
    static void Main(string[] args)
    {
        int[] array = { -1, 0, 1, 2, -1, -4 };

        IList<IList<int>> result = GroupOf3(array);

        Print(result);
    }

    public static IList<IList<int>> GroupOf3(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Array.Sort(nums); // Sort the array to make it easier to identify unique combinations.

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                int left = i + 1;
                int right = nums.Length - 1;
                int target = 0 - nums[i];

                while (left < right)
                {
                    int sum = nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Skip duplicates to avoid duplicate combinations.
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }

    public static void Print(IList<IList<int>> result)
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