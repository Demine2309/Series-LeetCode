namespace SeriesLeetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {

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
    Input: head = [1,2,3,4]
    Output: [2,1,4,3]

 * Example 2:
    Input: head = []
    Output: []

 * Example 3:
    Input: head = [1]
    Output: [1]
 */