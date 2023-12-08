namespace SeriesLeetCode
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int count = 0;

            while (num > 0)
            {
                if(num % 2 ==0)
                {
                    num = num / 2;
                    count++;
                }
                else
                {
                    num -= 1;
                    count++;
                }
            }

            return count;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int num = 14;
            int result = solution.NumberOfSteps(num);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: num = 14
    Output: 6
    Explanation: 
    Step 1) 14 is even; divide by 2 and obtain 7. 
    Step 2) 7 is odd; subtract 1 and obtain 6.
    Step 3) 6 is even; divide by 2 and obtain 3. 
    Step 4) 3 is odd; subtract 1 and obtain 2. 
    Step 5) 2 is even; divide by 2 and obtain 1. 
    Step 6) 1 is odd; subtract 1 and obtain 0.

 * Example 2:
    Input: num = 8
    Output: 4
    Explanation: 
    Step 1) 8 is even; divide by 2 and obtain 4. 
    Step 2) 4 is even; divide by 2 and obtain 2. 
    Step 3) 2 is even; divide by 2 and obtain 1. 
    Step 4) 1 is odd; subtract 1 and obtain 0.

 * Example 3:
    Input: num = 123
    Output: 12
 */